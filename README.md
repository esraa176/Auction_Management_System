# Auction_Management_System
Online Auction management system is a web based application which provide the users 
the ability to sell their own items or bid on available items. they can trade anything they want 
by posting ad.

The system works with two other systems; Report Generator System and Credit Service System. 
The Report Generator System generates a detailed Report for each bidded item once the 
Auction ends. The Credit Service System checks the buyer's credit card every time he bids on an 
item.

The purpose of this system is people invest their money to get maximum profit and knowledge 
about our system. All types of user can go and analyses the data of different field and get 
maximum profit for future investment. The system provides an easy solution to users to buy or 
sell their product with maximum profit online.



## User Requirements:
- The user has the ability to search for an item either by category 
or by product name, and see his transaction’s history.
- The seller has the ability to create auction, edit auction (update 
details or cancel) and see auction’s report after deadline.
- The buyer has the ability to bid on any item and use his credit 
card for payment.
- The Admin has the ability to cancel any auction.
- The system produces report after the deadline of each auction, it 
should contain the product’s details, the final bid amount on the 
product and the buyer who bid on it.


## Functional Requirements:
##### Login
– Description/ Action
 System will allow the user to login.
– Requirements/ Inputs
 User name and Password
– Source (source of inputs that will be entered into the function)
 Text box
– Post-condition (what will happen after the function execution)
 Username and Password checking
– Output (what will be displayed/generated after function execution)
Home page will be opened if the validation is true, An alert will appear if the validation 
is false.


##### Registeration
– Description/ Action
System will allow the user to create account using username, email , 
password, national ID , Credit Card No., and gender.
– Requirements/ Inputs
username, email , password, national ID and gender, Credit card No.
– Source (source of inputs that will be entered into the function)
Text box, Radio button
– Post-condition (what will happen after the function execution)
Check if Username doesn’t exist before, Password isn’t less than 10 characters, 
National ID is 14 numbers, Radio button is checked. If all of the above is True, 
Account is created.
– Output (what will be displayed/generated after function execution
Home page will be opened if the validation is true. An alert will appear if the 
validation is false.


##### Create Auction
– Description/ Action
The seller can trade anything they want by posting ad and put a minimum value for 
this product’s bid.
– Requirements/ Inputs
The seller should set product’s name, description, category, minimum value for 
bidding and deadline for this auction.
– Source (source of inputs that will be entered into the function)
Text box, Combo Box.
– Pre-condition (what should be true so that function can start)
The user is logged into the system.
– Post-condition (what will happen after the function execution)
Check if the user has set all the required data (Description is optional).
– Output (what will be displayed/generated after function execution)
An alert saying that bidding is done successfully and product appears in bided 
products in the system.


##### Search for item
– Description/ Action
The user can search for anything in the system either by name or category.
– Requirements/ Inputs
Name or Category.
– Source (source of inputs that will be entered into the function)
Text box, Combo Box
– Pre-condition (what should be true so that function can start)
The user is logged into the system.
– Post-condition (what will happen after the function execution)
Check if the user has entered required data for searching.
– Output (what will be displayed/generated after function execution
The searched item appears (if found).
- Bid on Item
– Description/ Action
 The buyer bid on item by entering a value more than the current bidding value for this 
product
– Requirements/ Inputs
 Bid value.
– Source (source of inputs that will be entered into the function)
 Text box.
– Pre-condition (what should be true so that function can start)
 The user is logged into the system.
– Post-condition (what will happen after the function execution)
 Check if the user has a credit with value greater than or equal the bidding amount.
– Output (what will be displayed/generated after function execution)
 An alert saying that bidding is done successfully (If credit is found) and an alert saying 
bidding is unsuccessful (If credit isn’t found).


##### Show History
– Description/ Action
The user can display all his transactions.
– Requirements/ Inputs
Click the button
– Source (source of inputs that will be entered into the function)
 button
– Pre-condition (what should be true so that function can start)
 The user is logged into the system.
– Output (what will be displayed/generated after function execution)
 Show user’s history.
 
 
 
## Non-Functional Requirements:
1- Security Requirements: The user’s data is secured.
 
2- Usability requirements: The system usage is easy for users to interact with.
 
3- Development Requirements: The system is implemented by C#.
 
4- Development Requirements: The System is implemented on Visual Studio IDE.
 
5- Efficieny requirements: The system has high performance and small space.
 
