USE [LibraryDemo]
GO
DELETE FROM [dbo].[LibraryTransactionType]
GO
SET IDENTITY_INSERT [dbo].[LibraryTransactionType] ON 
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (1, N'BOOK_ADD            ', N'Add a book to the inventory')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (2, N'BOOK_DEL            ', N'Remove a book from the inventory')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (3, N'BOOK_UPDATE         ', N'Update a book''s details')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (4, N'BOOK_CHECKOUT       ', N'Checkout a book')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (5, N'BOOK_CHECKIN        ', N'Check in a book')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (6, N'CUSTOMER_ADD        ', N'Add a new customer')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (7, N'CUSTOMER_DEL        ', N'Remove a customer')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (8, N'CUSTOMER_RENEW      ', N'Renew a customer''s membership')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (9, N'CUSTOMER_UPDATE     ', N'Update a customer''s details')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (10, N'AUTHOR_ADD          ', N'Add an author')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (11, N'AUTHOR_DEL          ', N'Remove an author')
GO
INSERT [dbo].[LibraryTransactionType] ([LibraryTransactionTypeId], [Code], [Description]) VALUES (12, N'AUTHOR_UPDATE       ', N'Update an author''s details')
GO
SET IDENTITY_INSERT [dbo].[LibraryTransactionType] OFF
GO
