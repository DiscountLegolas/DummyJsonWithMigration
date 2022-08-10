using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryName);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    discountPercentage = table.Column<double>(type: "float", nullable: false),
                    rating = table.Column<double>(type: "float", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_category",
                        column: x => x.category,
                        principalTable: "Categories",
                        principalColumn: "CategoryName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Url);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                column: "CategoryName",
                values: new object[]
                {
                    "automotive",
                    "fragrances",
                    "furniture",
                    "groceries",
                    "home-decoration",
                    "laptops",
                    "lighting",
                    "mens-shirts",
                    "mens-shoes",
                    "mens-watches",
                    "motorcycle",
                    "skincare",
                    "smartphones",
                    "sunglasses",
                    "tops",
                    "womens-bags",
                    "womens-dresses",
                    "womens-jewellery",
                    "womens-shoes",
                    "womens-watches"
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "category", "description", "discountPercentage", "price", "rating", "stock", "thumbnail", "title" },
                values: new object[,]
                {
                    { 1, "Apple", "smartphones", "An apple mobile which is nothing like apple", 12.960000000000001, 549, 4.6900000000000004, 94, "https://dummyjson.com/image/i/products/1/thumbnail.jpg", "iPhone 9" },
                    { 2, "Apple", "smartphones", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 17.940000000000001, 899, 4.4400000000000004, 34, "https://dummyjson.com/image/i/products/2/thumbnail.jpg", "iPhone X" },
                    { 3, "Samsung", "smartphones", "Samsung's new variant which goes beyond Galaxy to the Universe", 15.460000000000001, 1249, 4.0899999999999999, 36, "https://dummyjson.com/image/i/products/3/thumbnail.jpg", "Samsung Universe 9" },
                    { 4, "OPPO", "smartphones", "OPPO F19 is officially announced on April 2021.", 17.91, 280, 4.2999999999999998, 123, "https://dummyjson.com/image/i/products/4/thumbnail.jpg", "OPPOF19" },
                    { 5, "Huawei", "smartphones", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 10.58, 499, 4.0899999999999999, 32, "https://dummyjson.com/image/i/products/5/thumbnail.jpg", "Huawei P30" },
                    { 6, "APPle", "laptops", "MacBook Pro 2021 with mini-LED display may launch between September, November", 11.02, 1749, 4.5700000000000003, 83, "https://dummyjson.com/image/i/products/6/thumbnail.png", "MacBook Pro" },
                    { 7, "Samsung", "laptops", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 4.1500000000000004, 1499, 4.25, 50, "https://dummyjson.com/image/i/products/7/thumbnail.jpg", "Samsung Galaxy Book" },
                    { 8, "Microsoft Surface", "laptops", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 10.23, 1499, 4.4299999999999997, 68, "https://dummyjson.com/image/i/products/8/thumbnail.jpg", "Microsoft Surface Laptop 4" },
                    { 9, "Infinix", "laptops", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 11.83, 1099, 4.54, 96, "https://dummyjson.com/image/i/products/9/thumbnail.jpg", "Infinix INBOOK" },
                    { 10, "HP Pavilion", "laptops", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 6.1799999999999997, 1099, 4.4299999999999997, 89, "https://dummyjson.com/image/i/products/10/thumbnail.jpeg", "HP Pavilion 15-DK1056WM" },
                    { 11, "Impression of Acqua Di Gio", "fragrances", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 8.4000000000000004, 13, 4.2599999999999998, 65, "https://dummyjson.com/image/i/products/11/thumbnail.jpg", "perfume Oil" },
                    { 12, "Royal_Mirage", "fragrances", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 15.66, 40, 4.0, 52, "https://dummyjson.com/image/i/products/12/thumbnail.jpg", "Brown Perfume" },
                    { 13, "Fog Scent Xpressio", "fragrances", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 8.1400000000000006, 13, 4.5899999999999999, 61, "https://dummyjson.com/image/i/products/13/thumbnail.webp", "Fog Scent Xpressio Perfume" },
                    { 14, "Al Munakh", "fragrances", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 15.6, 120, 4.21, 114, "https://dummyjson.com/image/i/products/14/thumbnail.jpg", "Non-Alcoholic Concentrated Perfume Oil" },
                    { 15, "Lord - Al-Rehab", "fragrances", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 10.99, 30, 4.7000000000000002, 105, "https://dummyjson.com/image/i/products/15/thumbnail.jpg", "Eau De Perfume Spray" },
                    { 16, "L'Oreal Paris", "skincare", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 13.31, 19, 4.8300000000000001, 110, "https://dummyjson.com/image/i/products/16/thumbnail.jpg", "Hyaluronic Acid Serum" },
                    { 17, "Hemani Tea", "skincare", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 4.0899999999999999, 12, 4.5199999999999996, 78, "https://dummyjson.com/image/i/products/17/thumbnail.jpg", "Tree Oil 30ml" },
                    { 18, "Dermive", "skincare", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 13.1, 40, 4.5599999999999996, 88, "https://dummyjson.com/image/i/products/18/thumbnail.jpg", "Oil Free Moisturizer 100ml" },
                    { 19, "ROREC White Rice", "skincare", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 10.68, 46, 4.4199999999999999, 54, "https://dummyjson.com/image/i/products/19/thumbnail.jpg", "Skin Beauty Serum." },
                    { 20, "Fair & Clear", "skincare", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 16.989999999999998, 70, 4.0599999999999996, 140, "https://dummyjson.com/image/i/products/20/thumbnail.jpg", "Freckle Treatment Cream- 15gm" },
                    { 21, "Saaf & Khaas", "groceries", "Fine quality Branded Product Keep in a cool and dry place", 4.8099999999999996, 20, 4.4400000000000004, 133, "https://dummyjson.com/image/i/products/21/thumbnail.png", "- Daal Masoor 500 grams" },
                    { 22, "Bake Parlor Big", "groceries", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 15.58, 14, 4.5700000000000003, 146, "https://dummyjson.com/image/i/products/22/thumbnail.jpg", "Elbow Macaroni - 400 gm" },
                    { 23, "Baking Food Items", "groceries", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 8.0399999999999991, 14, 4.8499999999999996, 26, "https://dummyjson.com/image/i/products/23/thumbnail.jpg", "Orange Essence Food Flavou" },
                    { 24, "fauji", "groceries", "original fauji cereal muesli 250gm box pack original fauji cereals muesli fruit nuts flakes breakfast cereal break fast faujicereals cerels cerel foji fouji", 16.800000000000001, 46, 4.9400000000000004, 113, "https://dummyjson.com/image/i/products/24/thumbnail.jpg", "cereals muesli fruit nuts" },
                    { 25, "Dry Rose", "groceries", "Dry Rose Flower Powder Gulab Powder 50 Gram • Treats Wounds", 13.58, 70, 4.8700000000000001, 47, "https://dummyjson.com/image/i/products/25/thumbnail.jpg", "Gulab Powder 50 Gram" },
                    { 26, "Boho Decor", "home-decoration", "Boho Decor Plant Hanger For Home Wall Decoration Macrame Wall Hanging Shelf", 17.859999999999999, 41, 4.0800000000000001, 131, "https://dummyjson.com/image/i/products/26/thumbnail.jpg", "Plant Hanger For Home" },
                    { 27, "Flying Wooden", "home-decoration", "Package Include 6 Birds with Adhesive Tape Shape: 3D Shaped Wooden Birds Material: Wooden MDF, Laminated 3.5mm", 15.58, 51, 4.4100000000000001, 17, "https://dummyjson.com/image/i/products/27/thumbnail.webp", "Flying Wooden Bird" },
                    { 28, "LED Lights", "home-decoration", "3D led lamp sticker Wall sticker 3d wall art light on/off button  cell operated (included)", 16.489999999999998, 20, 4.8200000000000003, 54, "https://dummyjson.com/image/i/products/28/thumbnail.jpg", "3D Embellishment Art Lamp" },
                    { 29, "luxury palace", "home-decoration", "Handcraft Chinese style art luxury palace hotel villa mansion home decor ceramic vase with brass fruit plate", 15.34, 60, 4.4400000000000004, 7, "https://dummyjson.com/image/i/products/29/thumbnail.webp", "Handcraft Chinese style" },
                    { 30, "Golden", "home-decoration", "Attractive DesignMetallic materialFour key hooksReliable & DurablePremium Quality", 2.9199999999999999, 30, 4.9199999999999999, 54, "https://dummyjson.com/image/i/products/30/thumbnail.jpg", "Key Holder" },
                    { 31, "Furniture Bed Set", "furniture", "Mornadi Velvet Bed Base with Headboard Slats Support Classic Style Bedroom Furniture Bed Set", 17.0, 40, 4.1600000000000001, 140, "https://dummyjson.com/image/i/products/31/thumbnail.jpg", "Mornadi Velvet Bed" },
                    { 32, "Ratttan Outdoor", "furniture", "Ratttan Outdoor furniture Set Waterproof  Rattan Sofa for Coffe Cafe", 15.59, 50, 4.7400000000000002, 30, "https://dummyjson.com/image/i/products/32/thumbnail.jpg", "Sofa for Coffe Cafe" },
                    { 33, "Kitchen Shelf", "furniture", "3 Tier Corner Shelves | 3 PCs Wall Mount Kitchen Shelf | Floating Bedroom Shelf", 17.0, 700, 4.3099999999999996, 106, "https://dummyjson.com/image/i/products/33/thumbnail.jpg", "3 Tier Corner Shelves" },
                    { 34, "Multi Purpose", "furniture", "V﻿ery good quality plastic table for multi purpose now in reasonable price", 4.0, 50, 4.0099999999999998, 136, "https://dummyjson.com/image/i/products/34/thumbnail.jpg", "Plastic Table" },
                    { 35, "AmnaMart", "furniture", "Material: Stainless Steel and Fabric  Item Size: 110 cm x 45 cm x 175 cm Package Contents: 1 Storage Wardrobe", 7.9800000000000004, 41, 4.0599999999999996, 68, "https://dummyjson.com/image/i/products/35/thumbnail.jpg", "3 DOOR PORTABLE" },
                    { 36, "Professional Wear", "tops", "Cotton Solid Color Professional Wear Sleeve Shirt Womens Work Blouses Wholesale Clothing Casual Plain Custom Top OEM Customized", 10.890000000000001, 90, 4.2599999999999998, 39, "https://dummyjson.com/image/i/products/36/thumbnail.jpg", "Sleeve Shirt Womens" },
                    { 37, "Soft Cotton", "tops", "PACK OF 3 CAMISOLES ,VERY COMFORTABLE SOFT COTTON STUFF, COMFORTABLE IN ALL FOUR SEASONS", 12.050000000000001, 50, 4.5199999999999996, 107, "https://dummyjson.com/image/i/products/37/thumbnail.jpg", "ank Tops for Womens/Girls" },
                    { 38, "Soft Cotton", "tops", "sublimation plain kids tank tops wholesale", 11.119999999999999, 100, 4.7999999999999998, 20, "https://dummyjson.com/image/i/products/38/thumbnail.jpg", "sublimation plain kids tank" },
                    { 39, "Top Sweater", "tops", "2021 Custom Winter Fall Zebra Knit Crop Top Women Sweaters Wool Mohair Cos Customize Crew Neck Women' S Crop Top Sweater", 17.199999999999999, 600, 4.5499999999999998, 55, "https://dummyjson.com/image/i/products/39/thumbnail.jpg", "Women Sweaters Wool" },
                    { 40, "Top Sweater", "tops", "women winter clothes thick fleece hoodie top with sweat pantjogger women sweatsuit set joggers pants two piece pants set", 13.390000000000001, 57, 4.9100000000000001, 84, "https://dummyjson.com/image/i/products/40/thumbnail.jpg", "women winter clothes" },
                    { 41, "RED MICKY MOUSE..", "womens-dresses", "NIGHT SUIT RED MICKY MOUSE..  For Girls. Fantastic Suits.", 15.050000000000001, 55, 4.6500000000000004, 21, "https://dummyjson.com/image/i/products/41/thumbnail.webp", "NIGHT SUIT" },
                    { 42, "Digital Printed", "womens-dresses", "FABRIC: LILEIN CHEST: 21 LENGHT: 37 TROUSER: (38) :ARABIC LILEIN", 15.369999999999999, 80, 4.0499999999999998, 148, "https://dummyjson.com/image/i/products/42/thumbnail.jpg", "Stiched Kurta plus trouser" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "category", "description", "discountPercentage", "price", "rating", "stock", "thumbnail", "title" },
                values: new object[,]
                {
                    { 43, "Ghazi Fabric", "womens-dresses", "Ghazi fabric long frock gold printed ready to wear stitched collection (G992)", 15.550000000000001, 600, 4.3099999999999996, 150, "https://dummyjson.com/image/i/products/43/thumbnail.jpg", "frock gold printed" },
                    { 44, "Ghazi Fabric", "womens-dresses", "This classy shirt for women gives you a gorgeous look on everyday wear and specially for semi-casual wears.", 16.879999999999999, 79, 4.0300000000000002, 2, "https://dummyjson.com/image/i/products/44/thumbnail.jpg", "Ladies Multicolored Dress" },
                    { 45, "IELGY", "womens-dresses", "Ready to wear, Unique design according to modern standard fashion, Best fitting ,Imported stuff", 5.0700000000000003, 50, 4.6699999999999999, 96, "https://dummyjson.com/image/i/products/45/thumbnail.jpg", "Malai Maxi Dress" },
                    { 46, "IELGY fashion", "womens-shoes", "Close: Lace, Style with bottom: Increased inside, Sole Material: Rubber", 16.960000000000001, 40, 4.1399999999999997, 72, "https://dummyjson.com/image/i/products/46/thumbnail.jpg", "women's shoes" },
                    { 47, "Synthetic Leather", "womens-shoes", "Synthetic Leather Casual Sneaker shoes for Women/girls Sneakers For Women", 10.369999999999999, 120, 4.1900000000000004, 50, "https://dummyjson.com/image/i/products/47/thumbnail.jpeg", "Sneaker shoes" },
                    { 48, "Sandals Flip Flops", "womens-shoes", "Features: Flip-flops, Mid Heel, Comfortable, Striped Heel, Antiskid, Striped", 10.83, 40, 4.0199999999999996, 25, "https://dummyjson.com/image/i/products/48/thumbnail.jpg", "Women Strip Heel" },
                    { 49, "Maasai Sandals", "womens-shoes", "Womens Chappals & Shoe Ladies Metallic Tong Thong Sandal Flat Summer 2020 Maasai Sandals", 2.6200000000000001, 23, 4.7199999999999998, 107, "https://dummyjson.com/image/i/products/49/thumbnail.jpg", "Chappals & Shoe Ladies Metallic" },
                    { 50, "Arrivals Genuine", "womens-shoes", "2020 New Arrivals Genuine Leather Fashion Trend Platform Summer Women Shoes", 16.870000000000001, 36, 4.3300000000000001, 46, "https://dummyjson.com/image/i/products/50/thumbnail.jpg", "Women Shoes" },
                    { 51, "Vintage Apparel", "mens-shirts", "Many store is creating new designs and trend every month and every year. Daraz.pk have a beautiful range of men fashion brands", 12.76, 23, 4.2599999999999998, 132, "https://dummyjson.com/image/i/products/51/thumbnail.jpg", "half sleeves T shirts" },
                    { 52, "FREE FIRE", "mens-shirts", "quality and professional print - It doesn't just look high quality, it is high quality.", 14.720000000000001, 10, 4.5199999999999996, 128, "https://dummyjson.com/image/i/products/52/thumbnail.jpg", "FREE FIRE T Shirt" },
                    { 53, "Vintage Apparel", "mens-shirts", "Brand: vintage Apparel ,Export quality", 7.54, 35, 4.8899999999999997, 6, "https://dummyjson.com/image/i/products/53/thumbnail.jpg", "printed high quality T shirts" },
                    { 54, "The Warehouse", "mens-shirts", "Product Description Features: 100% Ultra soft Polyester Jersey. Vibrant & colorful printing on front. Feels soft as cotton without ever cracking", 16.440000000000001, 46, 4.6200000000000001, 136, "https://dummyjson.com/image/i/products/54/thumbnail.jpg", "Pubg Printed Graphic T-Shirt" },
                    { 55, "The Warehouse", "mens-shirts", "Fabric Jercy, Size: M & L Wear Stylish Dual Stiched", 15.970000000000001, 66, 4.9000000000000004, 122, "https://dummyjson.com/image/i/products/55/thumbnail.jpg", "Money Heist Printed Summer T Shirts" },
                    { 56, "Sneakers", "mens-shoes", "Gender: Men , Colors: Same as DisplayedCondition: 100% Brand New", 12.57, 40, 4.3799999999999999, 6, "https://dummyjson.com/image/i/products/56/thumbnail.jpg", "Sneakers Joggers Shoes" },
                    { 57, "Rubber", "mens-shoes", "Men Shoes - Loafers for men - Rubber Shoes - Nylon Shoes - Shoes for men - Moccassion - Pure Nylon (Rubber) Expot Quality.", 10.91, 47, 4.9100000000000001, 20, "https://dummyjson.com/image/i/products/57/thumbnail.jpg", "Loafers for men" },
                    { 58, "The Warehouse", "mens-shoes", "Pattern Type: Solid, Material: PU, Toe Shape: Pointed Toe ,Outsole Material: Rubber", 12.0, 57, 4.4100000000000001, 68, "https://dummyjson.com/image/i/products/58/thumbnail.jpg", "formal offices shoes" },
                    { 59, "Sneakers", "mens-shoes", "Comfortable stretch cloth, lightweight body; ,rubber sole, anti-skid wear;", 8.7100000000000009, 20, 4.3300000000000001, 137, "https://dummyjson.com/image/i/products/59/thumbnail.jpg", "Spring and summershoes" },
                    { 60, "Sneakers", "mens-shoes", "High Quality ,Stylish design ,Comfortable wear ,FAshion ,Durable", 7.5499999999999998, 58, 4.5499999999999998, 129, "https://dummyjson.com/image/i/products/60/thumbnail.jpg", "Stylish Casual Jeans Shoes" },
                    { 61, "Naviforce", "mens-watches", "Style:Sport ,Clasp:Buckles ,Water Resistance Depth:3Bar", 7.1399999999999997, 120, 4.6299999999999999, 91, "https://dummyjson.com/image/i/products/61/thumbnail.jpg", "Leather Straps Wristwatch" },
                    { 62, "SKMEI 9117", "mens-watches", "Watch Crown With Environmental IPS Bronze Electroplating; Display system of 12 hours", 3.1499999999999999, 46, 4.0499999999999998, 95, "https://dummyjson.com/image/i/products/62/thumbnail.jpg", "Waterproof Leather Brand Watch" },
                    { 63, "SKMEI 9117", "mens-watches", "Men Silver Chain Royal Blue Premium Watch Latest Analog Watch", 2.5600000000000001, 50, 4.8899999999999997, 142, "https://dummyjson.com/image/i/products/63/thumbnail.webp", "Royal Blue Premium Watch" },
                    { 64, "Strap Skeleton", "mens-watches", "Leather Strap Skeleton Watch for Men - Stylish and Latest Design", 10.199999999999999, 46, 4.9800000000000004, 61, "https://dummyjson.com/image/i/products/64/thumbnail.jpg", "Leather Strap Skeleton Watch" },
                    { 65, "Stainless", "mens-watches", "Stylish Watch For Man (Luxury) Classy Men's Stainless Steel Wrist Watch - Box Packed", 17.789999999999999, 47, 4.79, 94, "https://dummyjson.com/image/i/products/65/thumbnail.webp", "Stainless Steel Wrist Watch" },
                    { 66, "Eastern Watches", "womens-watches", "Elegant design, Stylish ,Unique & Trendy,Comfortable wear", 3.23, 35, 4.79, 24, "https://dummyjson.com/image/i/products/66/thumbnail.jpg", "Steel Analog Couple Watches" },
                    { 67, "Eastern Watches", "womens-watches", "Buy this awesome  The product is originally manufactured by the company and it's a top selling product with a very reasonable", 16.690000000000001, 60, 4.0300000000000002, 46, "https://dummyjson.com/image/i/products/67/thumbnail.jpg", "Fashion Magnetic Wrist Watch" },
                    { 68, "Luxury Digital", "womens-watches", "Stylish Luxury Digital Watch For Girls / Women - Led Smart Ladies Watches For Girls", 9.0299999999999994, 57, 4.5499999999999998, 77, "https://dummyjson.com/image/i/products/68/thumbnail.webp", "Stylish Luxury Digital Watch" },
                    { 69, "Watch Pearls", "womens-watches", "Product details of Golden Watch Pearls Bracelet Watch For Girls - Golden Chain Ladies Bracelate Watch for Women", 17.550000000000001, 47, 4.7699999999999996, 89, "https://dummyjson.com/image/i/products/69/thumbnail.jpg", "Golden Watch Pearls Bracelet Watch" },
                    { 70, "Bracelet", "womens-watches", "Fashion Skmei 1830 Shell Dial Stainless Steel Women Wrist Watch Lady Bracelet Watch Quartz Watches Ladies", 8.9800000000000004, 35, 4.0800000000000001, 111, "https://dummyjson.com/image/i/products/70/thumbnail.jpg", "Stainless Steel Women" },
                    { 71, "LouisWill", "womens-bags", "LouisWill Women Shoulder Bags Long Clutches Cross Body Bags Phone Bags PU Leather Hand Bags Large Capacity Card Holders Zipper Coin Purses Fashion Crossbody Bags for Girls Ladies", 14.65, 46, 4.71, 17, "https://dummyjson.com/image/i/products/71/thumbnail.jpg", "Women Shoulder Bags" },
                    { 72, "LouisWill", "womens-bags", "This fashion is designed to add a charming effect to your casual outfit. This Bag is made of synthetic leather.", 17.5, 23, 4.9100000000000001, 27, "https://dummyjson.com/image/i/products/72/thumbnail.webp", "Handbag For Girls" },
                    { 73, "Bracelet", "womens-bags", "This fashion is designed to add a charming effect to your casual outfit. This Bag is made of synthetic leather.", 10.390000000000001, 44, 4.1799999999999997, 101, "https://dummyjson.com/image/i/products/73/thumbnail.jpg", "Fancy hand clutch" },
                    { 74, "Copenhagen Luxe", "womens-bags", "It features an attractive design that makes it a must have accessory in your collection. We sell different kind of bags for boys, kids, women, girls and also for unisex.", 11.19, 57, 4.0099999999999998, 43, "https://dummyjson.com/image/i/products/74/thumbnail.jpg", "Leather Hand Bag" },
                    { 75, "Steal Frame", "womens-bags", "Seven Pocket Women Bag Handbags Lady Shoulder Crossbody Bag Female Purse Seven Pocket Bag", 14.869999999999999, 68, 4.9299999999999997, 13, "https://dummyjson.com/image/i/products/75/thumbnail.jpg", "Seven Pocket Women Bag" },
                    { 76, "Darojay", "womens-jewellery", "Jewelry Type:RingsCertificate Type:NonePlating:Silver PlatedShapeattern:noneStyle:CLASSICReligious", 13.57, 70, 4.6100000000000003, 51, "https://dummyjson.com/image/i/products/76/thumbnail.jpg", "Silver Ring Set Women" },
                    { 77, "Copenhagen Luxe", "womens-jewellery", "Brand: The Greetings Flower Colour: RedRing Colour: GoldenSize: Adjustable", 3.2200000000000002, 100, 4.21, 149, "https://dummyjson.com/image/i/products/77/thumbnail.jpg", "Rose Ring" },
                    { 78, "Fashion Jewellery", "womens-jewellery", "Fashion Jewellery 3Pcs Adjustable Pearl Rhinestone Korean Style Open Rings For Women", 8.0199999999999996, 30, 4.6900000000000004, 9, "https://dummyjson.com/image/i/products/78/thumbnail.jpg", "Rhinestone Korean Style Open Rings" },
                    { 79, "Fashion Jewellery", "womens-jewellery", "Elegant Female Pearl Earrings Set Zircon Pearl Earings Women Party Accessories 9 Pairs/Set", 12.800000000000001, 30, 4.7400000000000002, 16, "https://dummyjson.com/image/i/products/79/thumbnail.jpg", "Elegant Female Pearl Earrings" },
                    { 80, "Cuff Butterfly", "womens-jewellery", "Pair Of Ear Cuff Butterfly Long Chain Pin Tassel Earrings - Silver ( Long Life Quality Product)", 17.75, 45, 4.5899999999999999, 9, "https://dummyjson.com/image/i/products/80/thumbnail.jpg", "Chain Pin Tassel Earrings" },
                    { 81, "Designer Sun Glasses", "sunglasses", "A pair of sunglasses can protect your eyes from being hurt. For car driving, vacation travel, outdoor activities, social gatherings,", 10.1, 19, 4.9400000000000004, 78, "https://dummyjson.com/image/i/products/81/thumbnail.jpg", "Round Silver Frame Sun Glasses" },
                    { 82, "Designer Sun Glasses", "sunglasses", "Orignal Metal Kabir Singh design 2020 Sunglasses Men Brand Designer Sun Glasses Kabir Singh Square Sunglass", 15.6, 50, 4.6200000000000001, 78, "https://dummyjson.com/image/i/products/82/thumbnail.jpg", "Kabir Singh Square Sunglass" },
                    { 83, "mastar watch", "sunglasses", "Wiley X Night Vision Yellow Glasses for Riders - Night Vision Anti Fog Driving Glasses - Free Night Glass Cover - Shield Eyes From Dust and Virus- For Night Sport Matches", 6.3300000000000001, 30, 4.9699999999999998, 115, "https://dummyjson.com/image/i/products/83/thumbnail.jpg", "Wiley X Night Vision Yellow Glasses" },
                    { 84, "mastar watch", "sunglasses", "Fashion Oversized Square Sunglasses Retro Gradient Big Frame Sunglasses For Women One Piece Gafas Shade Mirror Clear Lens 17059", 13.890000000000001, 28, 4.6399999999999997, 64, "https://dummyjson.com/image/i/products/84/thumbnail.jpg", "Square Sunglasses" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "category", "description", "discountPercentage", "price", "rating", "stock", "thumbnail", "title" },
                values: new object[,]
                {
                    { 85, "LouisWill", "sunglasses", "LouisWill Men Sunglasses Polarized Sunglasses UV400 Sunglasses Day Night Dual Use Safety Driving Night Vision Eyewear AL-MG Frame Sun Glasses with Free Box for Drivers", 11.27, 50, 4.9800000000000004, 92, "https://dummyjson.com/image/i/products/85/thumbnail.jpg", "LouisWill Men Sunglasses" },
                    { 86, "Car Aux", "automotive", "Bluetooth Aux Bluetooth Car Aux Car Bluetooth Transmitter Aux Audio Receiver Handfree Car Bluetooth Music Receiver Universal 3.5mm Streaming A2DP Wireless Auto AUX Audio Adapter With Mic For Phone MP3", 10.56, 25, 4.5700000000000003, 22, "https://dummyjson.com/image/i/products/86/thumbnail.jpg", "Bluetooth Aux" },
                    { 87, "W1209 DC12V", "automotive", "Both Heat and Cool Purpose, Temperature control range; -50 to +110, Temperature measurement accuracy; 0.1, Control accuracy; 0.1", 11.300000000000001, 40, 4.54, 37, "https://dummyjson.com/image/i/products/87/thumbnail.jpg", "t Temperature Controller Incubator Controller" },
                    { 88, "TC Reusable", "automotive", "TC Reusable Silicone Magic Washing Gloves with Scrubber, Cleaning Brush Scrubber Gloves Heat Resistant Pair for Cleaning of Kitchen, Dishes, Vegetables and Fruits, Bathroom, Car Wash, Pet Care and Multipurpose", 3.1899999999999999, 29, 4.9800000000000004, 42, "https://dummyjson.com/image/i/products/88/thumbnail.jpg", "TC Reusable Silicone Magic Washing Gloves" },
                    { 89, "TC Reusable", "automotive", "best Quality CHarger , Highly Recommended to all best Quality CHarger , Highly Recommended to all", 17.530000000000001, 40, 4.2000000000000002, 79, "https://dummyjson.com/image/i/products/89/thumbnail.jpg", "Qualcomm original Car Charger" },
                    { 90, "Neon LED Light", "automotive", "Universal fitment and easy to install no special wires, can be easily installed and removed. Fits most standard tyre air stem valves of road, mountain bicycles, motocycles and cars.Bright led will turn on w", 11.08, 35, 4.0999999999999996, 63, "https://dummyjson.com/image/i/products/90/thumbnail.jpg", "Cycle Bike Glow" },
                    { 91, "METRO 70cc Motorcycle - MR70", "motorcycle", "Engine Type:Wet sump, Single Cylinder, Four Stroke, Two Valves, Air Cooled with SOHC (Single Over Head Cam) Chain Drive Bore & Stroke:47.0 x 49.5 MM", 13.630000000000001, 569, 4.04, 115, "https://dummyjson.com/image/i/products/91/thumbnail.jpg", "Black Motorbike" },
                    { 92, "BRAVE BULL", "motorcycle", "HOT SALE IN EUROPE electric racing motorcycle electric motorcycle for sale adult electric motorcycles", 14.4, 920, 4.1900000000000004, 22, "https://dummyjson.com/image/i/products/92/thumbnail.jpg", "HOT SALE IN EUROPE electric racing motorcycle" },
                    { 93, "shock absorber", "motorcycle", "150cc 4-Stroke Motorcycle Automatic Motor Gas Motorcycles Scooter motorcycles 150cc scooter", 3.3399999999999999, 1050, 4.8399999999999999, 127, "https://dummyjson.com/image/i/products/93/thumbnail.jpg", "Automatic Motor Gas Motorcycles" },
                    { 94, "JIEPOLLY", "motorcycle", "new arrivals Fashion motocross goggles motorcycle motocross racing motorcycle", 3.8500000000000001, 900, 4.0599999999999996, 109, "https://dummyjson.com/image/i/products/94/thumbnail.webp", "new arrivals Fashion motocross goggles" },
                    { 95, "Xiangle", "motorcycle", "Wholesale cargo lashing Belt Tie Down end Ratchet strap customized strap 25mm motorcycle 1500kgs with rubber handle", 17.670000000000002, 930, 4.21, 144, "https://dummyjson.com/image/i/products/95/thumbnail.jpg", "Wholesale cargo lashing Belt" },
                    { 96, "lightingbrilliance", "lighting", "Wholesale slim hanging decorative kid room lighting ceiling kitchen chandeliers pendant light modern", 14.890000000000001, 30, 4.8300000000000001, 96, "https://dummyjson.com/image/i/products/96/thumbnail.jpg", "lighting ceiling kitchen" },
                    { 97, "Ifei Home", "lighting", "Metal Ceramic Flower Chandelier Home Lighting American Vintage Hanging Lighting Pendant Lamp", 10.94, 35, 4.9299999999999997, 146, "https://dummyjson.com/image/i/products/97/thumbnail.jpg", "Metal Ceramic Flower" },
                    { 98, "DADAWU", "lighting", "3 lights lndenpant kitchen islang dining room pendant rice paper chandelier contemporary led pendant light modern chandelier", 5.9199999999999999, 34, 4.9900000000000002, 44, "https://dummyjson.com/image/i/products/98/thumbnail.jpg", "3 lights lndenpant kitchen islang" },
                    { 99, "Ifei Home", "lighting", "American Vintage Wood Pendant Light Farmhouse Antique Hanging Lamp Lampara Colgante", 8.8399999999999999, 46, 4.3200000000000003, 138, "https://dummyjson.com/image/i/products/99/thumbnail.jpg", "American Vintage Wood Pendant Light" },
                    { 100, "YIOSI", "lighting", "Crystal chandelier maria theresa for 12 light", 16.0, 47, 4.7400000000000002, 133, "https://dummyjson.com/image/i/products/100/thumbnail.jpg", "Crystal chandelier maria theresa for 12 light" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/1/1.jpg", 1 },
                    { "https://dummyjson.com/image/i/products/1/2.jpg", 1 },
                    { "https://dummyjson.com/image/i/products/1/3.jpg", 1 },
                    { "https://dummyjson.com/image/i/products/1/4.jpg", 1 },
                    { "https://dummyjson.com/image/i/products/1/thumbnail.jpg", 1 },
                    { "https://dummyjson.com/image/i/products/10/1.jpg", 10 },
                    { "https://dummyjson.com/image/i/products/10/2.jpg", 10 },
                    { "https://dummyjson.com/image/i/products/10/3.jpg", 10 },
                    { "https://dummyjson.com/image/i/products/10/thumbnail.jpeg", 10 },
                    { "https://dummyjson.com/image/i/products/100/1.jpg", 100 },
                    { "https://dummyjson.com/image/i/products/100/2.jpg", 100 },
                    { "https://dummyjson.com/image/i/products/100/3.jpg", 100 },
                    { "https://dummyjson.com/image/i/products/100/thumbnail.jpg", 100 },
                    { "https://dummyjson.com/image/i/products/11/1.jpg", 11 },
                    { "https://dummyjson.com/image/i/products/11/2.jpg", 11 },
                    { "https://dummyjson.com/image/i/products/11/3.jpg", 11 },
                    { "https://dummyjson.com/image/i/products/11/thumbnail.jpg", 11 },
                    { "https://dummyjson.com/image/i/products/12/1.jpg", 12 },
                    { "https://dummyjson.com/image/i/products/12/2.jpg", 12 },
                    { "https://dummyjson.com/image/i/products/12/3.png", 12 },
                    { "https://dummyjson.com/image/i/products/12/4.jpg", 12 },
                    { "https://dummyjson.com/image/i/products/12/thumbnail.jpg", 12 },
                    { "https://dummyjson.com/image/i/products/13/1.jpg", 13 },
                    { "https://dummyjson.com/image/i/products/13/2.png", 13 },
                    { "https://dummyjson.com/image/i/products/13/3.jpg", 13 },
                    { "https://dummyjson.com/image/i/products/13/4.jpg", 13 },
                    { "https://dummyjson.com/image/i/products/13/thumbnail.webp", 13 },
                    { "https://dummyjson.com/image/i/products/14/1.jpg", 14 },
                    { "https://dummyjson.com/image/i/products/14/2.jpg", 14 },
                    { "https://dummyjson.com/image/i/products/14/3.jpg", 14 },
                    { "https://dummyjson.com/image/i/products/14/thumbnail.jpg", 14 },
                    { "https://dummyjson.com/image/i/products/15/1.jpg", 15 },
                    { "https://dummyjson.com/image/i/products/15/2.jpg", 15 },
                    { "https://dummyjson.com/image/i/products/15/3.jpg", 15 },
                    { "https://dummyjson.com/image/i/products/15/4.jpg", 15 },
                    { "https://dummyjson.com/image/i/products/15/thumbnail.jpg", 15 },
                    { "https://dummyjson.com/image/i/products/16/1.png", 16 },
                    { "https://dummyjson.com/image/i/products/16/2.webp", 16 },
                    { "https://dummyjson.com/image/i/products/16/3.jpg", 16 },
                    { "https://dummyjson.com/image/i/products/16/4.jpg", 16 },
                    { "https://dummyjson.com/image/i/products/16/thumbnail.jpg", 16 },
                    { "https://dummyjson.com/image/i/products/17/1.jpg", 17 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/17/2.jpg", 17 },
                    { "https://dummyjson.com/image/i/products/17/3.jpg", 17 },
                    { "https://dummyjson.com/image/i/products/17/thumbnail.jpg", 17 },
                    { "https://dummyjson.com/image/i/products/18/1.jpg", 18 },
                    { "https://dummyjson.com/image/i/products/18/2.jpg", 18 },
                    { "https://dummyjson.com/image/i/products/18/3.jpg", 18 },
                    { "https://dummyjson.com/image/i/products/18/4.jpg", 18 },
                    { "https://dummyjson.com/image/i/products/18/thumbnail.jpg", 18 },
                    { "https://dummyjson.com/image/i/products/19/1.jpg", 19 },
                    { "https://dummyjson.com/image/i/products/19/2.jpg", 19 },
                    { "https://dummyjson.com/image/i/products/19/3.png", 19 },
                    { "https://dummyjson.com/image/i/products/19/thumbnail.jpg", 19 },
                    { "https://dummyjson.com/image/i/products/2/1.jpg", 2 },
                    { "https://dummyjson.com/image/i/products/2/2.jpg", 2 },
                    { "https://dummyjson.com/image/i/products/2/3.jpg", 2 },
                    { "https://dummyjson.com/image/i/products/2/thumbnail.jpg", 2 },
                    { "https://dummyjson.com/image/i/products/20/1.jpg", 20 },
                    { "https://dummyjson.com/image/i/products/20/2.jpg", 20 },
                    { "https://dummyjson.com/image/i/products/20/3.jpg", 20 },
                    { "https://dummyjson.com/image/i/products/20/4.jpg", 20 },
                    { "https://dummyjson.com/image/i/products/20/thumbnail.jpg", 20 },
                    { "https://dummyjson.com/image/i/products/21/1.png", 21 },
                    { "https://dummyjson.com/image/i/products/21/2.jpg", 21 },
                    { "https://dummyjson.com/image/i/products/21/3.jpg", 21 },
                    { "https://dummyjson.com/image/i/products/22/1.jpg", 22 },
                    { "https://dummyjson.com/image/i/products/22/2.jpg", 22 },
                    { "https://dummyjson.com/image/i/products/22/3.jpg", 22 },
                    { "https://dummyjson.com/image/i/products/23/1.jpg", 23 },
                    { "https://dummyjson.com/image/i/products/23/2.jpg", 23 },
                    { "https://dummyjson.com/image/i/products/23/3.jpg", 23 },
                    { "https://dummyjson.com/image/i/products/23/4.jpg", 23 },
                    { "https://dummyjson.com/image/i/products/23/thumbnail.jpg", 23 },
                    { "https://dummyjson.com/image/i/products/24/1.jpg", 24 },
                    { "https://dummyjson.com/image/i/products/24/2.jpg", 24 },
                    { "https://dummyjson.com/image/i/products/24/3.jpg", 24 },
                    { "https://dummyjson.com/image/i/products/24/4.jpg", 24 },
                    { "https://dummyjson.com/image/i/products/24/thumbnail.jpg", 24 },
                    { "https://dummyjson.com/image/i/products/25/1.png", 25 },
                    { "https://dummyjson.com/image/i/products/25/2.jpg", 25 },
                    { "https://dummyjson.com/image/i/products/25/3.png", 25 },
                    { "https://dummyjson.com/image/i/products/25/4.jpg", 25 },
                    { "https://dummyjson.com/image/i/products/25/thumbnail.jpg", 25 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/26/1.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/26/2.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/26/3.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/26/4.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/26/5.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/26/thumbnail.jpg", 26 },
                    { "https://dummyjson.com/image/i/products/27/1.jpg", 27 },
                    { "https://dummyjson.com/image/i/products/27/2.jpg", 27 },
                    { "https://dummyjson.com/image/i/products/27/3.jpg", 27 },
                    { "https://dummyjson.com/image/i/products/27/4.jpg", 27 },
                    { "https://dummyjson.com/image/i/products/27/thumbnail.webp", 27 },
                    { "https://dummyjson.com/image/i/products/28/1.jpg", 28 },
                    { "https://dummyjson.com/image/i/products/28/2.jpg", 28 },
                    { "https://dummyjson.com/image/i/products/28/3.png", 28 },
                    { "https://dummyjson.com/image/i/products/28/4.jpg", 28 },
                    { "https://dummyjson.com/image/i/products/28/thumbnail.jpg", 28 },
                    { "https://dummyjson.com/image/i/products/29/1.jpg", 29 },
                    { "https://dummyjson.com/image/i/products/29/2.jpg", 29 },
                    { "https://dummyjson.com/image/i/products/29/3.webp", 29 },
                    { "https://dummyjson.com/image/i/products/29/4.webp", 29 },
                    { "https://dummyjson.com/image/i/products/29/thumbnail.webp", 29 },
                    { "https://dummyjson.com/image/i/products/3/1.jpg", 3 },
                    { "https://dummyjson.com/image/i/products/30/1.jpg", 30 },
                    { "https://dummyjson.com/image/i/products/30/2.jpg", 30 },
                    { "https://dummyjson.com/image/i/products/30/3.jpg", 30 },
                    { "https://dummyjson.com/image/i/products/30/thumbnail.jpg", 30 },
                    { "https://dummyjson.com/image/i/products/31/1.jpg", 31 },
                    { "https://dummyjson.com/image/i/products/31/2.jpg", 31 },
                    { "https://dummyjson.com/image/i/products/31/3.jpg", 31 },
                    { "https://dummyjson.com/image/i/products/31/4.jpg", 31 },
                    { "https://dummyjson.com/image/i/products/31/thumbnail.jpg", 31 },
                    { "https://dummyjson.com/image/i/products/32/1.jpg", 32 },
                    { "https://dummyjson.com/image/i/products/32/2.jpg", 32 },
                    { "https://dummyjson.com/image/i/products/32/3.jpg", 32 },
                    { "https://dummyjson.com/image/i/products/32/thumbnail.jpg", 32 },
                    { "https://dummyjson.com/image/i/products/33/1.jpg", 33 },
                    { "https://dummyjson.com/image/i/products/33/2.jpg", 33 },
                    { "https://dummyjson.com/image/i/products/33/3.jpg", 33 },
                    { "https://dummyjson.com/image/i/products/33/4.jpg", 33 },
                    { "https://dummyjson.com/image/i/products/33/thumbnail.jpg", 33 },
                    { "https://dummyjson.com/image/i/products/34/1.jpg", 34 },
                    { "https://dummyjson.com/image/i/products/34/2.jpg", 34 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/34/3.jpg", 34 },
                    { "https://dummyjson.com/image/i/products/34/4.jpg", 34 },
                    { "https://dummyjson.com/image/i/products/34/thumbnail.jpg", 34 },
                    { "https://dummyjson.com/image/i/products/35/1.jpg", 35 },
                    { "https://dummyjson.com/image/i/products/35/2.jpg", 35 },
                    { "https://dummyjson.com/image/i/products/35/3.jpg", 35 },
                    { "https://dummyjson.com/image/i/products/35/4.jpg", 35 },
                    { "https://dummyjson.com/image/i/products/35/thumbnail.jpg", 35 },
                    { "https://dummyjson.com/image/i/products/36/1.jpg", 36 },
                    { "https://dummyjson.com/image/i/products/36/2.webp", 36 },
                    { "https://dummyjson.com/image/i/products/36/3.webp", 36 },
                    { "https://dummyjson.com/image/i/products/36/4.jpg", 36 },
                    { "https://dummyjson.com/image/i/products/36/thumbnail.jpg", 36 },
                    { "https://dummyjson.com/image/i/products/37/1.jpg", 37 },
                    { "https://dummyjson.com/image/i/products/37/2.jpg", 37 },
                    { "https://dummyjson.com/image/i/products/37/3.jpg", 37 },
                    { "https://dummyjson.com/image/i/products/37/4.jpg", 37 },
                    { "https://dummyjson.com/image/i/products/37/thumbnail.jpg", 37 },
                    { "https://dummyjson.com/image/i/products/38/1.png", 38 },
                    { "https://dummyjson.com/image/i/products/38/2.jpg", 38 },
                    { "https://dummyjson.com/image/i/products/38/3.jpg", 38 },
                    { "https://dummyjson.com/image/i/products/38/4.jpg", 38 },
                    { "https://dummyjson.com/image/i/products/39/1.jpg", 39 },
                    { "https://dummyjson.com/image/i/products/39/2.jpg", 39 },
                    { "https://dummyjson.com/image/i/products/39/3.jpg", 39 },
                    { "https://dummyjson.com/image/i/products/39/4.jpg", 39 },
                    { "https://dummyjson.com/image/i/products/39/thumbnail.jpg", 39 },
                    { "https://dummyjson.com/image/i/products/4/1.jpg", 4 },
                    { "https://dummyjson.com/image/i/products/4/2.jpg", 4 },
                    { "https://dummyjson.com/image/i/products/4/3.jpg", 4 },
                    { "https://dummyjson.com/image/i/products/4/4.jpg", 4 },
                    { "https://dummyjson.com/image/i/products/4/thumbnail.jpg", 4 },
                    { "https://dummyjson.com/image/i/products/40/1.jpg", 40 },
                    { "https://dummyjson.com/image/i/products/40/2.jpg", 40 },
                    { "https://dummyjson.com/image/i/products/41/1.jpg", 41 },
                    { "https://dummyjson.com/image/i/products/41/2.webp", 41 },
                    { "https://dummyjson.com/image/i/products/41/3.jpg", 41 },
                    { "https://dummyjson.com/image/i/products/41/4.jpg", 41 },
                    { "https://dummyjson.com/image/i/products/41/thumbnail.webp", 41 },
                    { "https://dummyjson.com/image/i/products/42/1.png", 42 },
                    { "https://dummyjson.com/image/i/products/42/2.png", 42 },
                    { "https://dummyjson.com/image/i/products/42/3.png", 42 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/42/4.jpg", 42 },
                    { "https://dummyjson.com/image/i/products/42/thumbnail.jpg", 42 },
                    { "https://dummyjson.com/image/i/products/43/1.jpg", 43 },
                    { "https://dummyjson.com/image/i/products/43/2.jpg", 43 },
                    { "https://dummyjson.com/image/i/products/43/3.jpg", 43 },
                    { "https://dummyjson.com/image/i/products/43/4.jpg", 43 },
                    { "https://dummyjson.com/image/i/products/43/thumbnail.jpg", 43 },
                    { "https://dummyjson.com/image/i/products/44/1.jpg", 44 },
                    { "https://dummyjson.com/image/i/products/44/2.jpg", 44 },
                    { "https://dummyjson.com/image/i/products/44/3.jpg", 44 },
                    { "https://dummyjson.com/image/i/products/44/4.jpg", 44 },
                    { "https://dummyjson.com/image/i/products/44/thumbnail.jpg", 44 },
                    { "https://dummyjson.com/image/i/products/45/1.jpg", 45 },
                    { "https://dummyjson.com/image/i/products/45/2.webp", 45 },
                    { "https://dummyjson.com/image/i/products/45/3.jpg", 45 },
                    { "https://dummyjson.com/image/i/products/45/4.jpg", 45 },
                    { "https://dummyjson.com/image/i/products/45/thumbnail.jpg", 45 },
                    { "https://dummyjson.com/image/i/products/46/1.webp", 46 },
                    { "https://dummyjson.com/image/i/products/46/2.jpg", 46 },
                    { "https://dummyjson.com/image/i/products/46/3.jpg", 46 },
                    { "https://dummyjson.com/image/i/products/46/4.jpg", 46 },
                    { "https://dummyjson.com/image/i/products/46/thumbnail.jpg", 46 },
                    { "https://dummyjson.com/image/i/products/47/1.jpg", 47 },
                    { "https://dummyjson.com/image/i/products/47/2.jpg", 47 },
                    { "https://dummyjson.com/image/i/products/47/3.jpg", 47 },
                    { "https://dummyjson.com/image/i/products/47/thumbnail.jpeg", 47 },
                    { "https://dummyjson.com/image/i/products/48/1.jpg", 48 },
                    { "https://dummyjson.com/image/i/products/48/2.jpg", 48 },
                    { "https://dummyjson.com/image/i/products/48/3.jpg", 48 },
                    { "https://dummyjson.com/image/i/products/48/4.jpg", 48 },
                    { "https://dummyjson.com/image/i/products/48/thumbnail.jpg", 48 },
                    { "https://dummyjson.com/image/i/products/49/1.jpg", 49 },
                    { "https://dummyjson.com/image/i/products/49/2.jpg", 49 },
                    { "https://dummyjson.com/image/i/products/49/3.webp", 49 },
                    { "https://dummyjson.com/image/i/products/49/thumbnail.jpg", 49 },
                    { "https://dummyjson.com/image/i/products/5/1.jpg", 5 },
                    { "https://dummyjson.com/image/i/products/5/2.jpg", 5 },
                    { "https://dummyjson.com/image/i/products/5/3.jpg", 5 },
                    { "https://dummyjson.com/image/i/products/50/1.jpeg", 50 },
                    { "https://dummyjson.com/image/i/products/50/2.jpg", 50 },
                    { "https://dummyjson.com/image/i/products/50/3.jpg", 50 },
                    { "https://dummyjson.com/image/i/products/51/1.png", 51 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/51/2.jpg", 51 },
                    { "https://dummyjson.com/image/i/products/51/3.jpg", 51 },
                    { "https://dummyjson.com/image/i/products/51/thumbnail.jpg", 51 },
                    { "https://dummyjson.com/image/i/products/52/1.png", 52 },
                    { "https://dummyjson.com/image/i/products/52/2.png", 52 },
                    { "https://dummyjson.com/image/i/products/52/3.jpg", 52 },
                    { "https://dummyjson.com/image/i/products/52/4.jpg", 52 },
                    { "https://dummyjson.com/image/i/products/52/thumbnail.jpg", 52 },
                    { "https://dummyjson.com/image/i/products/53/1.webp", 53 },
                    { "https://dummyjson.com/image/i/products/53/2.jpg", 53 },
                    { "https://dummyjson.com/image/i/products/53/3.jpg", 53 },
                    { "https://dummyjson.com/image/i/products/53/4.jpg", 53 },
                    { "https://dummyjson.com/image/i/products/53/thumbnail.jpg", 53 },
                    { "https://dummyjson.com/image/i/products/54/1.jpg", 54 },
                    { "https://dummyjson.com/image/i/products/54/2.jpg", 54 },
                    { "https://dummyjson.com/image/i/products/54/3.jpg", 54 },
                    { "https://dummyjson.com/image/i/products/54/4.jpg", 54 },
                    { "https://dummyjson.com/image/i/products/54/thumbnail.jpg", 54 },
                    { "https://dummyjson.com/image/i/products/55/1.jpg", 55 },
                    { "https://dummyjson.com/image/i/products/55/2.webp", 55 },
                    { "https://dummyjson.com/image/i/products/55/3.jpg", 55 },
                    { "https://dummyjson.com/image/i/products/55/4.jpg", 55 },
                    { "https://dummyjson.com/image/i/products/55/thumbnail.jpg", 55 },
                    { "https://dummyjson.com/image/i/products/56/1.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/56/2.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/56/3.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/56/4.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/56/5.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/56/thumbnail.jpg", 56 },
                    { "https://dummyjson.com/image/i/products/57/1.jpg", 57 },
                    { "https://dummyjson.com/image/i/products/57/2.jpg", 57 },
                    { "https://dummyjson.com/image/i/products/57/3.jpg", 57 },
                    { "https://dummyjson.com/image/i/products/57/4.jpg", 57 },
                    { "https://dummyjson.com/image/i/products/57/thumbnail.jpg", 57 },
                    { "https://dummyjson.com/image/i/products/58/1.jpg", 58 },
                    { "https://dummyjson.com/image/i/products/58/2.jpg", 58 },
                    { "https://dummyjson.com/image/i/products/58/3.jpg", 58 },
                    { "https://dummyjson.com/image/i/products/58/4.jpg", 58 },
                    { "https://dummyjson.com/image/i/products/58/thumbnail.jpg", 58 },
                    { "https://dummyjson.com/image/i/products/59/1.jpg", 59 },
                    { "https://dummyjson.com/image/i/products/59/2.jpg", 59 },
                    { "https://dummyjson.com/image/i/products/59/3.jpg", 59 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/59/4.jpg", 59 },
                    { "https://dummyjson.com/image/i/products/59/thumbnail.jpg", 59 },
                    { "https://dummyjson.com/image/i/products/6/1.png", 6 },
                    { "https://dummyjson.com/image/i/products/6/2.jpg", 6 },
                    { "https://dummyjson.com/image/i/products/6/3.png", 6 },
                    { "https://dummyjson.com/image/i/products/6/4.jpg", 6 },
                    { "https://dummyjson.com/image/i/products/60/1.jpg", 60 },
                    { "https://dummyjson.com/image/i/products/60/2.jpg", 60 },
                    { "https://dummyjson.com/image/i/products/60/3.jpg", 60 },
                    { "https://dummyjson.com/image/i/products/60/thumbnail.jpg", 60 },
                    { "https://dummyjson.com/image/i/products/61/1.jpg", 61 },
                    { "https://dummyjson.com/image/i/products/61/2.png", 61 },
                    { "https://dummyjson.com/image/i/products/61/3.jpg", 61 },
                    { "https://dummyjson.com/image/i/products/62/1.jpg", 62 },
                    { "https://dummyjson.com/image/i/products/62/2.jpg", 62 },
                    { "https://dummyjson.com/image/i/products/63/1.jpg", 63 },
                    { "https://dummyjson.com/image/i/products/63/2.jpg", 63 },
                    { "https://dummyjson.com/image/i/products/63/3.png", 63 },
                    { "https://dummyjson.com/image/i/products/63/4.jpeg", 63 },
                    { "https://dummyjson.com/image/i/products/64/1.jpg", 64 },
                    { "https://dummyjson.com/image/i/products/64/2.webp", 64 },
                    { "https://dummyjson.com/image/i/products/64/3.jpg", 64 },
                    { "https://dummyjson.com/image/i/products/64/thumbnail.jpg", 64 },
                    { "https://dummyjson.com/image/i/products/65/1.jpg", 65 },
                    { "https://dummyjson.com/image/i/products/65/2.webp", 65 },
                    { "https://dummyjson.com/image/i/products/65/3.jpg", 65 },
                    { "https://dummyjson.com/image/i/products/65/4.webp", 65 },
                    { "https://dummyjson.com/image/i/products/65/thumbnail.webp", 65 },
                    { "https://dummyjson.com/image/i/products/66/1.jpg", 66 },
                    { "https://dummyjson.com/image/i/products/66/2.jpg", 66 },
                    { "https://dummyjson.com/image/i/products/66/3.jpg", 66 },
                    { "https://dummyjson.com/image/i/products/66/4.JPG", 66 },
                    { "https://dummyjson.com/image/i/products/66/thumbnail.jpg", 66 },
                    { "https://dummyjson.com/image/i/products/67/1.jpg", 67 },
                    { "https://dummyjson.com/image/i/products/67/2.jpg", 67 },
                    { "https://dummyjson.com/image/i/products/67/3.jpg", 67 },
                    { "https://dummyjson.com/image/i/products/67/4.jpg", 67 },
                    { "https://dummyjson.com/image/i/products/67/thumbnail.jpg", 67 },
                    { "https://dummyjson.com/image/i/products/68/1.jpg", 68 },
                    { "https://dummyjson.com/image/i/products/68/2.jpg", 68 },
                    { "https://dummyjson.com/image/i/products/69/1.jpg", 69 },
                    { "https://dummyjson.com/image/i/products/69/2.jpg", 69 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/69/3.webp", 69 },
                    { "https://dummyjson.com/image/i/products/69/4.jpg", 69 },
                    { "https://dummyjson.com/image/i/products/69/thumbnail.jpg", 69 },
                    { "https://dummyjson.com/image/i/products/7/1.jpg", 7 },
                    { "https://dummyjson.com/image/i/products/7/2.jpg", 7 },
                    { "https://dummyjson.com/image/i/products/7/3.jpg", 7 },
                    { "https://dummyjson.com/image/i/products/7/thumbnail.jpg", 7 },
                    { "https://dummyjson.com/image/i/products/70/1.jpg", 70 },
                    { "https://dummyjson.com/image/i/products/70/2.jpg", 70 },
                    { "https://dummyjson.com/image/i/products/70/thumbnail.jpg", 70 },
                    { "https://dummyjson.com/image/i/products/71/1.jpg", 71 },
                    { "https://dummyjson.com/image/i/products/71/2.jpg", 71 },
                    { "https://dummyjson.com/image/i/products/71/3.webp", 71 },
                    { "https://dummyjson.com/image/i/products/71/thumbnail.jpg", 71 },
                    { "https://dummyjson.com/image/i/products/72/1.jpg", 72 },
                    { "https://dummyjson.com/image/i/products/72/2.png", 72 },
                    { "https://dummyjson.com/image/i/products/72/3.webp", 72 },
                    { "https://dummyjson.com/image/i/products/72/4.jpg", 72 },
                    { "https://dummyjson.com/image/i/products/72/thumbnail.webp", 72 },
                    { "https://dummyjson.com/image/i/products/73/1.jpg", 73 },
                    { "https://dummyjson.com/image/i/products/73/2.webp", 73 },
                    { "https://dummyjson.com/image/i/products/73/3.jpg", 73 },
                    { "https://dummyjson.com/image/i/products/73/thumbnail.jpg", 73 },
                    { "https://dummyjson.com/image/i/products/74/1.jpg", 74 },
                    { "https://dummyjson.com/image/i/products/74/2.jpg", 74 },
                    { "https://dummyjson.com/image/i/products/74/3.jpg", 74 },
                    { "https://dummyjson.com/image/i/products/74/4.jpg", 74 },
                    { "https://dummyjson.com/image/i/products/74/thumbnail.jpg", 74 },
                    { "https://dummyjson.com/image/i/products/75/1.jpg", 75 },
                    { "https://dummyjson.com/image/i/products/75/2.jpg", 75 },
                    { "https://dummyjson.com/image/i/products/75/3.jpg", 75 },
                    { "https://dummyjson.com/image/i/products/75/thumbnail.jpg", 75 },
                    { "https://dummyjson.com/image/i/products/76/1.jpg", 76 },
                    { "https://dummyjson.com/image/i/products/76/2.jpg", 76 },
                    { "https://dummyjson.com/image/i/products/76/thumbnail.jpg", 76 },
                    { "https://dummyjson.com/image/i/products/77/1.jpg", 77 },
                    { "https://dummyjson.com/image/i/products/77/2.jpg", 77 },
                    { "https://dummyjson.com/image/i/products/77/3.jpg", 77 },
                    { "https://dummyjson.com/image/i/products/77/thumbnail.jpg", 77 },
                    { "https://dummyjson.com/image/i/products/78/thumbnail.jpg", 78 },
                    { "https://dummyjson.com/image/i/products/79/1.jpg", 79 },
                    { "https://dummyjson.com/image/i/products/8/1.jpg", 8 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/8/2.jpg", 8 },
                    { "https://dummyjson.com/image/i/products/8/3.jpg", 8 },
                    { "https://dummyjson.com/image/i/products/8/4.jpg", 8 },
                    { "https://dummyjson.com/image/i/products/8/thumbnail.jpg", 8 },
                    { "https://dummyjson.com/image/i/products/80/1.jpg", 80 },
                    { "https://dummyjson.com/image/i/products/80/2.jpg", 80 },
                    { "https://dummyjson.com/image/i/products/80/3.png", 80 },
                    { "https://dummyjson.com/image/i/products/80/4.jpg", 80 },
                    { "https://dummyjson.com/image/i/products/80/thumbnail.jpg", 80 },
                    { "https://dummyjson.com/image/i/products/81/1.jpg", 81 },
                    { "https://dummyjson.com/image/i/products/81/2.jpg", 81 },
                    { "https://dummyjson.com/image/i/products/81/3.jpg", 81 },
                    { "https://dummyjson.com/image/i/products/81/4.webp", 81 },
                    { "https://dummyjson.com/image/i/products/81/thumbnail.jpg", 81 },
                    { "https://dummyjson.com/image/i/products/82/1.jpg", 82 },
                    { "https://dummyjson.com/image/i/products/82/2.webp", 82 },
                    { "https://dummyjson.com/image/i/products/82/3.jpg", 82 },
                    { "https://dummyjson.com/image/i/products/82/4.jpg", 82 },
                    { "https://dummyjson.com/image/i/products/82/thumbnail.jpg", 82 },
                    { "https://dummyjson.com/image/i/products/83/1.jpg", 83 },
                    { "https://dummyjson.com/image/i/products/83/2.jpg", 83 },
                    { "https://dummyjson.com/image/i/products/83/3.jpg", 83 },
                    { "https://dummyjson.com/image/i/products/83/4.jpg", 83 },
                    { "https://dummyjson.com/image/i/products/83/thumbnail.jpg", 83 },
                    { "https://dummyjson.com/image/i/products/84/1.jpg", 84 },
                    { "https://dummyjson.com/image/i/products/84/2.jpg", 84 },
                    { "https://dummyjson.com/image/i/products/84/thumbnail.jpg", 84 },
                    { "https://dummyjson.com/image/i/products/85/1.jpg", 85 },
                    { "https://dummyjson.com/image/i/products/85/2.jpg", 85 },
                    { "https://dummyjson.com/image/i/products/85/thumbnail.jpg", 85 },
                    { "https://dummyjson.com/image/i/products/86/1.jpg", 86 },
                    { "https://dummyjson.com/image/i/products/86/2.webp", 86 },
                    { "https://dummyjson.com/image/i/products/86/3.jpg", 86 },
                    { "https://dummyjson.com/image/i/products/86/4.jpg", 86 },
                    { "https://dummyjson.com/image/i/products/86/thumbnail.jpg", 86 },
                    { "https://dummyjson.com/image/i/products/87/1.jpg", 87 },
                    { "https://dummyjson.com/image/i/products/87/2.jpg", 87 },
                    { "https://dummyjson.com/image/i/products/87/3.jpg", 87 },
                    { "https://dummyjson.com/image/i/products/87/4.jpg", 87 },
                    { "https://dummyjson.com/image/i/products/87/thumbnail.jpg", 87 },
                    { "https://dummyjson.com/image/i/products/88/1.jpg", 88 },
                    { "https://dummyjson.com/image/i/products/88/2.jpg", 88 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/88/3.jpg", 88 },
                    { "https://dummyjson.com/image/i/products/88/4.webp", 88 },
                    { "https://dummyjson.com/image/i/products/88/thumbnail.jpg", 88 },
                    { "https://dummyjson.com/image/i/products/89/1.jpg", 89 },
                    { "https://dummyjson.com/image/i/products/89/2.jpg", 89 },
                    { "https://dummyjson.com/image/i/products/89/3.jpg", 89 },
                    { "https://dummyjson.com/image/i/products/89/4.jpg", 89 },
                    { "https://dummyjson.com/image/i/products/89/thumbnail.jpg", 89 },
                    { "https://dummyjson.com/image/i/products/9/1.jpg", 9 },
                    { "https://dummyjson.com/image/i/products/9/2.png", 9 },
                    { "https://dummyjson.com/image/i/products/9/3.png", 9 },
                    { "https://dummyjson.com/image/i/products/9/4.jpg", 9 },
                    { "https://dummyjson.com/image/i/products/9/thumbnail.jpg", 9 },
                    { "https://dummyjson.com/image/i/products/90/1.jpg", 90 },
                    { "https://dummyjson.com/image/i/products/90/2.jpg", 90 },
                    { "https://dummyjson.com/image/i/products/90/3.jpg", 90 },
                    { "https://dummyjson.com/image/i/products/90/4.jpg", 90 },
                    { "https://dummyjson.com/image/i/products/90/thumbnail.jpg", 90 },
                    { "https://dummyjson.com/image/i/products/91/1.jpg", 91 },
                    { "https://dummyjson.com/image/i/products/91/2.jpg", 91 },
                    { "https://dummyjson.com/image/i/products/91/3.jpg", 91 },
                    { "https://dummyjson.com/image/i/products/91/4.jpg", 91 },
                    { "https://dummyjson.com/image/i/products/91/thumbnail.jpg", 91 },
                    { "https://dummyjson.com/image/i/products/92/1.jpg", 92 },
                    { "https://dummyjson.com/image/i/products/92/2.jpg", 92 },
                    { "https://dummyjson.com/image/i/products/92/3.jpg", 92 },
                    { "https://dummyjson.com/image/i/products/92/4.jpg", 92 },
                    { "https://dummyjson.com/image/i/products/93/1.jpg", 93 },
                    { "https://dummyjson.com/image/i/products/93/2.jpg", 93 },
                    { "https://dummyjson.com/image/i/products/93/3.jpg", 93 },
                    { "https://dummyjson.com/image/i/products/93/4.jpg", 93 },
                    { "https://dummyjson.com/image/i/products/93/thumbnail.jpg", 93 },
                    { "https://dummyjson.com/image/i/products/94/1.webp", 94 },
                    { "https://dummyjson.com/image/i/products/94/2.jpg", 94 },
                    { "https://dummyjson.com/image/i/products/94/3.jpg", 94 },
                    { "https://dummyjson.com/image/i/products/94/thumbnail.webp", 94 },
                    { "https://dummyjson.com/image/i/products/95/1.jpg", 95 },
                    { "https://dummyjson.com/image/i/products/95/2.jpg", 95 },
                    { "https://dummyjson.com/image/i/products/95/3.jpg", 95 },
                    { "https://dummyjson.com/image/i/products/95/4.jpg", 95 },
                    { "https://dummyjson.com/image/i/products/95/thumbnail.jpg", 95 },
                    { "https://dummyjson.com/image/i/products/96/1.jpg", 96 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Url", "ProductId" },
                values: new object[,]
                {
                    { "https://dummyjson.com/image/i/products/96/2.jpg", 96 },
                    { "https://dummyjson.com/image/i/products/96/3.jpg", 96 },
                    { "https://dummyjson.com/image/i/products/96/4.jpg", 96 },
                    { "https://dummyjson.com/image/i/products/96/thumbnail.jpg", 96 },
                    { "https://dummyjson.com/image/i/products/97/1.jpg", 97 },
                    { "https://dummyjson.com/image/i/products/97/2.jpg", 97 },
                    { "https://dummyjson.com/image/i/products/97/3.jpg", 97 },
                    { "https://dummyjson.com/image/i/products/97/4.webp", 97 },
                    { "https://dummyjson.com/image/i/products/97/thumbnail.jpg", 97 },
                    { "https://dummyjson.com/image/i/products/98/1.jpg", 98 },
                    { "https://dummyjson.com/image/i/products/98/2.jpg", 98 },
                    { "https://dummyjson.com/image/i/products/98/3.jpg", 98 },
                    { "https://dummyjson.com/image/i/products/98/4.jpg", 98 },
                    { "https://dummyjson.com/image/i/products/98/thumbnail.jpg", 98 },
                    { "https://dummyjson.com/image/i/products/99/1.jpg", 99 },
                    { "https://dummyjson.com/image/i/products/99/2.jpg", 99 },
                    { "https://dummyjson.com/image/i/products/99/3.jpg", 99 },
                    { "https://dummyjson.com/image/i/products/99/4.jpg", 99 },
                    { "https://dummyjson.com/image/i/products/99/thumbnail.jpg", 99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_category",
                table: "Products",
                column: "category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
