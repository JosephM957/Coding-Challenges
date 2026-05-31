cart_data = [
    {"name": "Laptop", "category": "Electronics", "price": 1200.00, "quantity": 1},
    {"name": "Wireless Mouse", "category": "Electronics", "price": 25.50, "quantity": 2},
    {"name": "Graphic T-Shirt", "category": "Apparel", "price": 15.99, "quantity": 3},
    {"name": "Coffee Mug", "category": "Home", "price": 12.50, "quantity": 4}
]
def analyze_cart(cart):
    index = 0
    totalitems = 0
    totalprice = 0
    final_price = 0
    subtotal = 0
    category_breakdown = []
    for item in cart:
        totalitems += item["quantity"]
        totalprice += item["price"] * item["quantity"]
        category_breakdown.append(item["category"])
        index += 1
    add_catagories(category_breakdown)
    discount = check_discount(totalprice)
    subtotal = totalprice
    if (discount == True):
        print(totalprice)
        final_price = round((totalprice - (totalprice * .1)), 2)
    print(results(totalitems, subtotal, discount, final_price, category_breakdown))
    
def add_catagories(catagories) -> dict:
    catagorgy_counts = {"Electronics": 0, "Apparal": 0, "Home": 0}
    for catagorgy in catagories:
        if catagorgy == "Electronics":
            catagorgy_counts["Electronics"] += 1
        if catagorgy == "Apparel":
            catagorgy_counts["Apparal"] += 1
        if catagorgy == "Home":
            catagorgy_counts["Home"] += 1
    return catagorgy_counts
def check_discount(total) -> bool:
    if total > 100:
        return True
    return False
def results(items, subtotal, discount, final_total, category_breakdown) -> dict:
    return {"total_items": items, "subtotal": subtotal, "discount_applied": discount, "final_total": final_total, "category_breakdown": category_breakdown}
analyze_cart(cart_data)