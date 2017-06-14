SET IDENTITY_INSERT [dbo].[Projects] ON
INSERT INTO [dbo].[Projects] ([ProjectId], [Description], [Title]) VALUES (1, N'Corp portal for company 1', N'Project 1')
INSERT INTO [dbo].[Projects] ([ProjectId], [Description], [Title]) VALUES (2, N'Mobile app for company 2', N'Project 2')
SET IDENTITY_INSERT [dbo].[Projects] OFF
