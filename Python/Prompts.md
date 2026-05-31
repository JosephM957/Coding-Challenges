# Challenge 1
## Prompt
Give me a coding challenge for a junior programmer using only python
## Response
### Challenge: The E-commerce Cart Analyzer
### The Scenario
You are building the backend logic for a simple online store. The frontend sends you the user's shopping cart data as a list of dictionaries. You need to write a function that processes this raw data and returns a summary report.

### The Data
You will be working with a data structure that looks exactly like this:
```
Python
    {"name": "Laptop", "category": "Electronics", "price": 1200.00, "quantity": 1},
    {"name": "Wireless Mouse", "category": "Electronics", "price": 25.50, "quantity": 2},
    {"name": "Graphic T-Shirt", "category": "Apparel", "price": 15.99, "quantity": 3},
    {"name": "Coffee Mug", "category": "Home", "price": 12.50, "quantity": 4}
]
```
### Your Tasks
Write a function named analyze_cart(cart) that takes the list of dictionaries as an argument and returns a single dictionary containing the following insights:

total_items: The total number of physical items in the cart (factor in the quantity of each item).

subtotal: The total cost of the cart before any discounts are applied.

discount_applied: A boolean (True or False). You should apply a 10% discount to the subtotal only if the subtotal is strictly greater than $100.

final_total: The final cost after the discount is applied (if eligible). This number must be rounded to two decimal places.

category_breakdown: A nested dictionary where the keys are the unique categories (e.g., "Electronics", "Apparel") and the values are the total quantity of items purchased in that specific category.

### Expected Output
If you pass the cart_data above into your function, it should return exactly this:
```
Python
{
    'total_items': 10, 
    'subtotal': 1348.97, 
    'discount_applied': True, 
    'final_total': 1169.07, 
    'category_breakdown': {
        'Electronics': 3, 
        'Apparel': 3, 
        'Home': 4
    }
}
```
### A Confession: My Answer Key Was Wrong!
By bringing this up, you actually forced me to double-check my own work, and I have to apologize: I made a math error in the expected output of my original prompt.

In my previous response, I listed the expected subtotal as 1298.97. As an AI, I sometimes make careless calculation errors if I don't break the steps down—and in this case, I completely forgot to add the $50.00 for the coffee mugs to my own answer key!

Here is what the true expected output should look like if you write your code correctly:

Python
{
    'total_items': 10, 
    'subtotal': 1348.97, 
    'discount_applied': True, 
    'final_total': 1214.07,  # 1348.97 minus 10%
    'category_breakdown': {
        'Electronics': 3, 
        'Apparel': 3, 
        'Home': 4
    }
}
Good eye on checking the math. When you write your analyze_cart function, just make sure you are multiplying item["price"] * item["quantity"] inside your loop to get that correct $1348.97 subtotal!
