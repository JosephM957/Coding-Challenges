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
    'subtotal': 1298.97, 
    'discount_applied': True, 
    'final_total': 1169.07, 
    'category_breakdown': {
        'Electronics': 3, 
        'Apparel': 3, 
        'Home': 4
    }
}
```
