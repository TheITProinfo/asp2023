--comment 1
/* comment 2
please create database Market, tables "Customers"

*/

create database Market on
(
  name='Market',
  size=8MB,
  filegrowth=64MB,
  filename="C:\SqlDatabase\Market.mdf"
  
)
-- create LOG database
log on 
(
name='_log',
size=8MB,
filegrowth=64MB,
filename="C:\SqlDatabase\Market_log.ldf"
)