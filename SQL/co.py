# 学习：连接数据库
# 开发时间：2022/2/23 9:36
import pymysql

conn = pymysql.connect(host='127.0.0.1',user='root',port=3306,password='krms',db='test')
cur = conn.cursor()
sql = "insert into test.professor values('6666','武',23,'程序员');"
sql2 = "update test.professor set SSN = '6667' where age = 23;"
sql3 = "delete from test.professor where SSN = '2222'"
cur.execute(sql3)
cur2 = conn.cursor()
cur2.execute("select * from test.professor")
while 1:
    re = cur2.fetchone()
    if re is None:
        break
    print(re)
cur.close()
conn.commit()
conn.close()