USE [eCommerceDb]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210406113701_AllEntitiesAdded', N'5.0.1')
GO
INSERT [dbo].[Cart] ([CartId], [UserID], [DateCreated]) VALUES (N'0fbde2a0-7a73-40ab-b589-1fc096b5f5c3', 1, CAST(N'2021-05-08T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Bread')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Dairy')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Fruits')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Vegetables')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Seasonings')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (3, N'Spinach', N'Green, leafy and fresh spinach with high fibres and vitamins', CAST(1.20 AS Decimal(10, 2)), N'http://www.publicdomainpictures.net/pictures/170000/velka/spinach-leaves-1461774375kTU.jpg', N'Vegetables')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (4, N'Avacado', N'Avocados are a great source of vitamins C, and B-6, as well as riboflavin, niacin,, magnesium, and potassium', CAST(1.24 AS Decimal(10, 2)), N'https://pixnio.com/free-images/2017/03/17/2017-03-17-09-15-56.jpg', N'Fruits')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (5, N'Freshly Baked Bread', N'Freshly Baked Bread is whole grain, healthy and keeps vitamins level up with proper sugar and carbohydrates.', CAST(3.00 AS Decimal(10, 2)), N'https://static.pexels.com/photos/2434/bread-food-healthy-breakfast.jpg', N'Bread')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (6, N'Tomato', N'Tomato is the edible berry of the plant Solanum lycopersicum, commonly known as a tomato plant.', CAST(2.10 AS Decimal(10, 2)), N'https://static.pexels.com/photos/8390/food-wood-tomatoes.jpg', N'Vegetables')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (8, N'Banana', N'Banana is yellow in color and must be eaten in morning for better metabolism', CAST(1.89 AS Decimal(10, 2)), N'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Bananas.jpg/1024px-Bananas.jpg', N'Fruits')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [coverImagePath], [Category]) VALUES (9, N'Cinnamon Sticks', N'Cinnamon Sticks will help to add spice to your sabji and make it more masaledaar!', CAST(2.90 AS Decimal(10, 2)), N'https://upload.wikimedia.org/wikipedia/commons/8/8c/Cinnamon-other.jpg', N'Seasonings')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[UserMaster] ON 

INSERT [dbo].[UserMaster] ([UserID], [FirstName], [LastName], [Username], [Password], [Gender], [UserTypeID]) VALUES (1, N'Admin', N'User', N'adminuser', N'qwerty', N'Female', 1)
SET IDENTITY_INSERT [dbo].[UserMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[UserType] ON 

INSERT [dbo].[UserType] ([UserTypeID], [UserTypeName]) VALUES (1, N'Admin')
INSERT [dbo].[UserType] ([UserTypeID], [UserTypeName]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[UserType] OFF
GO
