This system contains 3 page, first one is Home page, second one is Create Task page & the last one is List of All Task page. User can access any page form other pages. In the Home page, contains 2 button by which user can access rest 2 pages. In the Create Page except 2 button by which user access rest 2 pages, also contains 2 text boxes & a button. By inputting data in this text boxes & clicking submit button user can create task & that task will be store in database. In the List of all Task page contains a Grid view where all the created task will show from the database along with a Delete button in every row. By clicking that Delete Button respected data of that row will be delete from the Database. After that Grid view, a text box contains with a button. By providing a valid id in that text box & clicking on the button, respected data against that ID will be visible at bottom of the page. From there user can update data. All the page contains required validation so that user cannot submit any button by providing any text box empty or any unexpected value.

In the database table, id was set as a primary key & rest were set as varchar. User only provide name & description. ID will increase one by one because of primary key, dateCreated & dateUpdated time will store in database through the system when user create task & update task. User can’t edit this 2 data by using the system.

For build this system, used technologies are:
Programming Language: C#
Framework: Visual Studio 2012
Database: Microsoft SQL Server 2012
