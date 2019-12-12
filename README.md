# DotnetCoreExam

## 公司員工管理系統

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

### 目標

一個具有以下功能的網站

- 瀏覽員工列表
- 新增員工
- 刪除員工

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

### 要求

- Clone本專案，從master開一條用自己英文姓名命名的branch並開始實作
- 使用本專案提供之MySql DB ( 請參閱 initial.sh )
- 建立名為 my_company 的 Database
- 建立名為 Employee 的 Table
- Employee 的欄位至少包含 id, name, salary
- 網頁畫面不拘，只要能夠執行 瀏覽/新增/刪除 功能即可
- 完成後，記得push自己的branch

＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

### 小抄

- [Lesson2](https://www.notion.so/Lesson2-75960747dba6490d9de6bdf43881d36e)
- [Lesson3](https://www.notion.so/Lesson-3-1488fc5fa831430fa3af174be0e5345d)
- Code First

> dotnet ef migrations add InitialCreat --context=WeatherDbContext

> dotnet ef database update --context=WeatherDbContext

- 一開始要cd到 Course.Tools，並執行

> sh initial.sh

- ConnectionStrings 記得要改
- startup.cs 內的 AddDbContext 記得要改
- [_ViewStart.cshtml](https://docs.microsoft.com/zh-tw/aspnet/core/mvc/views/layout?view=aspnetcore-3.1)
