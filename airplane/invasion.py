# 学习：飞机大战屏幕初始化
# 开发时间：2022/2/6 16:46
import sys
from time import sleep
import pygame
from settings import Setings
from game_stats import GameStats
from ship import Ship
from bullet import Bullet
from enemy import Enemy


class PlaneInvasion:     # 游戏初始化类
    def __init__(self):
        pygame.init()
        self.settings = Setings()               # 引用settings类变量
        self.screen = pygame.display.set_mode((self.settings.screen_width, self.settings.screen_hight))        # 设置屏幕
        pygame.display.set_caption('Plane Invasion')            # 标题设置
        self.ship = Ship(self)
        self.stats = GameStats(self)
        self.bullet = Bullet(self)
        self.bullets = pygame.sprite.Group()
        self.enemys = pygame.sprite.Group()
        self._create_fleet()

    def _create_fleet(self):
        enemy = Enemy(self)
        enemy_width, enemy_height = enemy.rect.size
        available_space_x = self.settings.screen_width - (2 * enemy_width)
        number_enemys_x = available_space_x // (2 * enemy_width)
        ship_height = self.ship.rect.height
        available_space_y = (self.settings.screen_hight - (3 * enemy_height) - ship_height)
        number_rows = available_space_y // (2 * enemy_height)
        for row_number in range(number_rows):
            for i in range(number_enemys_x):
                self._creat_enemy(i, row_number)

    def _creat_enemy(self, enemy_number, row_number):
        enemy = Enemy(self)
        enemy_width, enemy_height = enemy.rect.size
        enemy.x = enemy_width + 2 * enemy_width * enemy_number
        enemy.rect.x = enemy.x
        enemy.rect.y = enemy.rect.height + 2 * enemy.rect.height * row_number
        self.enemys.add(enemy)

    def run_game(self):         # 监视鼠标事件
        while True:
            self._check_events()
            if self.stats.game_active:
                self.ship.update()
                self.bullets_update()
                self._fire_bullet()
                self.enemy_update()
            self._update_screen()

    def _check_events(self):                    # 检测鼠标和键盘事件
        for event in pygame.event.get():
            if event.type == pygame.QUIT:       # 鼠标退出
                sys.exit()
            elif event.type == pygame.KEYDOWN:
                self._check_keydown_events(event)
            elif event.type == pygame.KEYUP:
                self._check_keyup_events(event)

    def _check_keydown_events(self, event):     # 键盘按下事件
        if event.key == pygame.K_RIGHT:
            self.ship.moving_right = True
        elif event.key == pygame.K_LEFT:
            self.ship.moving_left = True
        elif event.key == pygame.K_q:
            sys.exit()
        elif event.key == pygame.K_SPACE:
            self.bullet.open = True
            #self._fire_bullet()

    def _check_keyup_events(self, event):       # 键盘抬起事件
        if event.key == pygame.K_RIGHT:
            self.ship.moving_right = False
        elif event.key == pygame.K_LEFT:
            self.ship.moving_left = False
        elif event.key == pygame.K_SPACE:
            self.bullet.open = False

    def _fire_bullet(self):
        if self.bullet.open and len(self.bullets) <= self.settings.bullet_num:
            new_bullet = Bullet(self)
            self.bullets.add(new_bullet)

    def bullets_update(self):
        self.bullets.update()
        for bullet in self.bullets.copy():
            if bullet.rect.bottom <= 0:
                self.bullets.remove(bullet)
        collections = pygame.sprite.groupcollide(self.bullets, self.enemys, True, True)
        if not self.enemys:
            self.bullets.empty()
            self._create_fleet()
            self.settings.enemy_speed *= self.settings.speed_up
            self.settings.bullet_speed *= self.settings.speed_up

    def enemy_update(self):
        self._check_fleet_edges()
        self.enemys.update()
        if pygame.sprite.spritecollideany(self.ship, self.enemys):
            self.ship_hit()
        self.check_enemys_bottom()

    def _check_fleet_edges(self):
        """有外星人到达边缘时采取相应的措施。"""

        for enemy in self.enemys.sprites():
            if enemy.check_edg():
                self._change_fleet_direction(enemy)
                break

    def _change_fleet_direction(self, enemy):
        """将整群外星人下移，并改变它们的方向。"""
        for enemy in self.enemys.sprites():
            enemy.rect.y += self.settings.fleet_speed
        self.settings.fleet_driection *= -1

    def ship_hit(self):
        if self.stats.ships_left > 0:
            self.stats.ships_left -= 1
            self.enemys.empty()
            self.bullets.empty()
            self._create_fleet()
            self.ship.center_ship()
            sleep(0.5)
        else:
            self.stats.game_active = False

    def check_enemys_bottom(self):
        screen_rect = self.screen.get_rect()
        for enemy in self.enemys.sprites():
            if enemy.rect.bottom >= screen_rect.bottom:
                self.ship_hit()
                break

    def _update_screen(self):
        self.screen.fill(self.settings.bc_color)  # 设置背景色
        self.ship.blitme()
        for bullet in self.bullets.sprites():
            bullet.draw_bullet()
        self.enemys.draw(self.screen)
        pygame.display.flip()  # 屏幕刷新


if __name__ == '__main__':
    ai = PlaneInvasion()            # 实例对象显示
    ai.run_game()