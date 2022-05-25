/categories/index
-should display all categories present in database into an html table
-For each category, it should also display a hyperlink for details,edit,delete
-It should also have a hyperlink to add new category

/categories/add
-It should display a form for accepting category deatils
-Incase of invalid category details, validation messages must be displayed
-All validations must run on client side and server side
-If all validations passes, save the category in database
-Display ACK to the user
-Provide a hyperlink to get back to "categories/index" page

/categories/edit/categoryid
-It should display the existing category to the user in a form
-Form must have clinet-side and server-side validations
-On successful submission category must be updated in the database and the user must be redirected to index page
-Incase of failure display a message to the user on edit page itself
-Provide a hyperlink to list page

/categories/details/categoryid
-Fetch and display the category details in the view
-Should have hyperlink to edit page for current category and a hyperlink to list page

/category/delete/categoryid
-Fetch and display category details to the user
-When the user clicks delete button in the page, it must delete the category from the database
-On successful completion, redirect the user to index page
-On failure, display a message to the user
