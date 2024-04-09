1. Open "OrderDetails.sln"
2. In"Solution Explorer", I have added WebService named "VesigoOrderService" under Web References(just for your reference)
3. Created dbo.ORDERDETAILS table and INSERTORDERDETAILS Stored Procedure on my localDb (SQL Server). DB Scripts have been attached over email
4. Connected through ADO.NET using Windows Authentication (Trusted_Connection=yes)
5. Change the Connection String with yours before you execute the solution

Output:

1. Happy Path scenario:

	a. After execution, a connection will be made to Web Service and the data will be inserted into database. User will be popped up with a message "Order Details have been inserted into database. Click 'Ok' to view the list of orders." 
	b. Upon clicking 'Ok', user will be taken to form load where thye can see the order(s) on gridview which have been inserted into database during previous step

2. Failure scenario:

	a. Unable to connect to Webservice: User will be popped up with a message "There is an issue connecting to Webservice" appended with error message
	b. Unable to connect to Database: Error will be popped up on the screen


Below is the total time spent on this task:

1. Requirement Analysis  : 15 minutes
2. Design (DB & Windows) : 15 minutes 
3. Development		 : 20 minutes
4. Unit testing		 : 10 minutes

	Total		 : 1 hour
	