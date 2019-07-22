IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204034428_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204034428_Initial', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204044820_UpdatePagesForAgency')
BEGIN
    CREATE TABLE [Agency] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [WebSite] nvarchar(max) NULL,
        CONSTRAINT [PK_Agency] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204044820_UpdatePagesForAgency')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204044820_UpdatePagesForAgency', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204053838_AddedEmployerModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204053838_AddedEmployerModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204054741_AddedEmployerPages')
BEGIN
    CREATE TABLE [Employer] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [WebSite] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Address1] nvarchar(max) NULL,
        [Address2] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [ZipCode] tinyint NOT NULL,
        CONSTRAINT [PK_Employer] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204054741_AddedEmployerPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204054741_AddedEmployerPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204154826_ChangedEmployerModel')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'ZipCode');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [ZipCode] int NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204154826_ChangedEmployerModel')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'City');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [City] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204154826_ChangedEmployerModel')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'Address2');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [Address2] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204154826_ChangedEmployerModel')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'Address1');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [Address1] nvarchar(75) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204154826_ChangedEmployerModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204154826_ChangedEmployerModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204163248_ChangedEmployerModel2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204163248_ChangedEmployerModel2', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204164748_ChangedEmployerModel3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204164748_ChangedEmployerModel3', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204165147_ChangedEmployerModel4')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'ZipCode');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [ZipCode] nvarchar(5) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204165147_ChangedEmployerModel4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204165147_ChangedEmployerModel4', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204165956_ChangedEmployerModel5')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'ZipCode');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Employer] ALTER COLUMN [ZipCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204165956_ChangedEmployerModel5')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204165956_ChangedEmployerModel5', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204184840_AddedInitialJobModelAndPages')
BEGIN
    CREATE TABLE [Job] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Number] int NOT NULL,
        CONSTRAINT [PK_Job] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204184840_AddedInitialJobModelAndPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204184840_AddedInitialJobModelAndPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    ALTER TABLE [Job] ADD [AgencyId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    ALTER TABLE [Job] ADD [EmployerId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    CREATE INDEX [IX_Job_AgencyId] ON [Job] ([AgencyId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    CREATE INDEX [IX_Job_EmployerId] ON [Job] ([EmployerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Agency_AgencyId] FOREIGN KEY ([AgencyId]) REFERENCES [Agency] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Employer_EmployerId] FOREIGN KEY ([EmployerId]) REFERENCES [Employer] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204185812_AddedAssociationsWithJobs')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204185812_AddedAssociationsWithJobs', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204191150_AddedAssociationsWithJobs2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204191150_AddedAssociationsWithJobs2', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204224536_AddEmployerDropDownForNewJobs')
BEGIN
    ALTER TABLE [Job] DROP CONSTRAINT [FK_Job_Employer_EmployerId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204224536_AddEmployerDropDownForNewJobs')
BEGIN
    DROP INDEX [IX_Job_EmployerId] ON [Job];
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'EmployerId');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Job] ALTER COLUMN [EmployerId] int NOT NULL;
    CREATE INDEX [IX_Job_EmployerId] ON [Job] ([EmployerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204224536_AddEmployerDropDownForNewJobs')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Employer_EmployerId] FOREIGN KEY ([EmployerId]) REFERENCES [Employer] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204224536_AddEmployerDropDownForNewJobs')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204224536_AddEmployerDropDownForNewJobs', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204235232_AddedContactModelAndPages')
BEGIN
    CREATE TABLE [Contact] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Address1] nvarchar(75) NULL,
        [Address2] nvarchar(50) NULL,
        [City] nvarchar(50) NULL,
        [State] nvarchar(max) NULL,
        [ZipCode] nvarchar(max) NULL,
        [EmployerId] int NOT NULL,
        CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Contact_Employer_EmployerId] FOREIGN KEY ([EmployerId]) REFERENCES [Employer] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204235232_AddedContactModelAndPages')
BEGIN
    CREATE INDEX [IX_Contact_EmployerId] ON [Contact] ([EmployerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190204235232_AddedContactModelAndPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190204235232_AddedContactModelAndPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205013835_UpdatedEmployerContactJobRelations')
BEGIN
    ALTER TABLE [Job] ADD [ContactId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205013835_UpdatedEmployerContactJobRelations')
BEGIN
    ALTER TABLE [Contact] ADD [Title] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205013835_UpdatedEmployerContactJobRelations')
BEGIN
    CREATE INDEX [IX_Job_ContactId] ON [Job] ([ContactId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205013835_UpdatedEmployerContactJobRelations')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Contact_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [Contact] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205013835_UpdatedEmployerContactJobRelations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205013835_UpdatedEmployerContactJobRelations', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205015549_AddedDescriptionToJobModelAndPages')
BEGIN
    ALTER TABLE [Job] ADD [Description] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205015549_AddedDescriptionToJobModelAndPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205015549_AddedDescriptionToJobModelAndPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205024114_AddedJobIdToEmployerModel')
BEGIN
    ALTER TABLE [Employer] ADD [JobId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205024114_AddedJobIdToEmployerModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205024114_AddedJobIdToEmployerModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205152504_CutJobIdFromEmployerModel')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'JobId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Employer] DROP COLUMN [JobId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205152504_CutJobIdFromEmployerModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205152504_CutJobIdFromEmployerModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205195538_UpdateDisplayTypesForPhoneAndZipInContacts')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205195538_UpdateDisplayTypesForPhoneAndZipInContacts', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205202213_AddedInteractions')
BEGIN
    CREATE TABLE [Action] (
        [Id] int NOT NULL IDENTITY,
        [Type] int NOT NULL,
        [JobId] int NULL,
        CONSTRAINT [PK_Action] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Action_Job_JobId] FOREIGN KEY ([JobId]) REFERENCES [Job] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205202213_AddedInteractions')
BEGIN
    CREATE INDEX [IX_Action_JobId] ON [Action] ([JobId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205202213_AddedInteractions')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205202213_AddedInteractions', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Action]') AND [c].[name] = N'Type');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Action] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Action] DROP COLUMN [Type];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    ALTER TABLE [Action] ADD [TypeId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    CREATE TABLE [InteractionTypes] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_InteractionTypes] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    CREATE INDEX [IX_Action_TypeId] ON [Action] ([TypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    ALTER TABLE [Action] ADD CONSTRAINT [FK_Action_InteractionTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [InteractionTypes] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205526_AddInteractionTypesModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205205526_AddInteractionTypesModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Call')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Write')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Email')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Visit')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Interview')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Offer')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Accept')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Decline')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('WillFollowUp')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('DidFollowUp')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('RequestInfo')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Applied')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205205554_SeedInteractionTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205205554_SeedInteractionTypes', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205212454_AddInteractionTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205212454_AddInteractionTypes', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Action] DROP CONSTRAINT [FK_Action_Job_JobId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Action] DROP CONSTRAINT [FK_Action_InteractionTypes_TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Action] DROP CONSTRAINT [PK_Action];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    EXEC sp_rename N'[Action]', N'Interactions';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    EXEC sp_rename N'[Interactions].[IX_Action_TypeId]', N'IX_Interactions_TypeId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    EXEC sp_rename N'[Interactions].[IX_Action_JobId]', N'IX_Interactions_JobId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [PK_Interactions] PRIMARY KEY ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_Job_JobId] FOREIGN KEY ([JobId]) REFERENCES [Job] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_InteractionTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [InteractionTypes] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205214350_UpdatedDbContextAndAddedInteractionTypesPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205220630_AddedJobIdtoInteractionModel')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_Job_JobId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205220630_AddedJobIdtoInteractionModel')
BEGIN
    DROP INDEX [IX_Interactions_JobId] ON [Interactions];
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'JobId');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Interactions] ALTER COLUMN [JobId] int NOT NULL;
    CREATE INDEX [IX_Interactions_JobId] ON [Interactions] ([JobId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205220630_AddedJobIdtoInteractionModel')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_Job_JobId] FOREIGN KEY ([JobId]) REFERENCES [Job] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190205220630_AddedJobIdtoInteractionModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190205220630_AddedJobIdtoInteractionModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206021746_FixedDescriptionOfNewJob')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[InteractionTypes]') AND [c].[name] = N'Name');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [InteractionTypes] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [InteractionTypes] ALTER COLUMN [Name] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206021746_FixedDescriptionOfNewJob')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206021746_FixedDescriptionOfNewJob', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_InteractionTypes_TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    DROP INDEX [IX_Interactions_TypeId] ON [Interactions];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'TypeId');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Interactions] DROP COLUMN [TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    ALTER TABLE [Interactions] ADD [InteractionTypesId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    ALTER TABLE [Interactions] ADD [TargetTime] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    CREATE INDEX [IX_Interactions_InteractionTypesId] ON [Interactions] ([InteractionTypesId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_InteractionTypes_InteractionTypesId] FOREIGN KEY ([InteractionTypesId]) REFERENCES [InteractionTypes] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206170857_FixedRelationshipBetweenInteractionsAndTypes', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206172039_ReconstructedInteractionPages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206172039_ReconstructedInteractionPages', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206172817_ChangedTimeColumnOnInteractionTable')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'TargetTime');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Interactions] ALTER COLUMN [TargetTime] Date NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206172817_ChangedTimeColumnOnInteractionTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206172817_ChangedTimeColumnOnInteractionTable', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206173640_MadeChangeToDateDataTypeInInteractionModel')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'TargetTime');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Interactions] ALTER COLUMN [TargetTime] datetime2 NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206173640_MadeChangeToDateDataTypeInInteractionModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206173640_MadeChangeToDateDataTypeInInteractionModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Call')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Write')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Email')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Visit')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Interview')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Offer')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Accept')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Decline')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('WillFollowUp')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('DidFollowUp')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('RequestInfo')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Applied')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190206211623_SeedInteractionTypesII')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190206211623_SeedInteractionTypesII', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207164125_AddIconsToAgency')
BEGIN
    ALTER TABLE [Agency] ADD [IconSrc] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207164125_AddIconsToAgency')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190207164125_AddIconsToAgency', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207171859_AddedNotesToInteraction')
BEGIN
    ALTER TABLE [Interactions] ADD [Notes] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207171859_AddedNotesToInteraction')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190207171859_AddedNotesToInteraction', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Call')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Write')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Email')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Visit')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Interview')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Offer')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Accept')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Decline')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Will Follow Up')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Did Follow Up')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Request Info')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO InteractionTypes (Name) VALUES ('Applied')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190207223456_UpdateSeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190207223456_UpdateSeedData', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190208215137_AddedUserModel')
BEGIN
    CREATE TABLE [User] (
        [Id] int NOT NULL IDENTITY,
        [OwnerId] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [Zip] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190208215137_AddedUserModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190208215137_AddedUserModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190208224156_DeleteUserModel')
BEGIN
    DROP TABLE [User];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190208224156_DeleteUserModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190208224156_DeleteUserModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Job] ADD [PersonId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Interactions] ADD [PersonId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Employer] ADD [PersonId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Contact] ADD [PersonId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Agency] ADD [PersonId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE TABLE [Persons] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Address1] nvarchar(75) NULL,
        [Address2] nvarchar(50) NULL,
        [City] nvarchar(50) NULL,
        [State] nvarchar(max) NULL,
        [ZipCode] nvarchar(max) NULL,
        [UserId] int NOT NULL,
        [UserId1] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_Persons] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Persons_AspNetUsers_UserId1] FOREIGN KEY ([UserId1]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE TABLE [Document] (
        [Id] int NOT NULL IDENTITY,
        [Content] nvarchar(max) NULL,
        [ContentSize] bigint NOT NULL,
        [UploadDT] datetime2 NOT NULL,
        [PersonId] int NULL,
        [PersonId1] int NULL,
        CONSTRAINT [PK_Document] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Document_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Document_Persons_PersonId1] FOREIGN KEY ([PersonId1]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Job_PersonId] ON [Job] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Interactions_PersonId] ON [Interactions] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Employer_PersonId] ON [Employer] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Contact_PersonId] ON [Contact] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Agency_PersonId] ON [Agency] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Document_PersonId] ON [Document] ([PersonId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Document_PersonId1] ON [Document] ([PersonId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    CREATE INDEX [IX_Persons_UserId1] ON [Persons] ([UserId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Agency] ADD CONSTRAINT [FK_Agency_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Contact] ADD CONSTRAINT [FK_Contact_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Employer] ADD CONSTRAINT [FK_Employer_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Persons_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Persons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209003839_AddPersonClassWithDependencies')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209003839_AddPersonClassWithDependencies', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031333_AddedIconModel')
BEGIN
    CREATE TABLE [Icons] (
        [Id] int NOT NULL IDENTITY,
        [Source] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Icons] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031333_AddedIconModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209031333_AddedIconModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/glassdoor.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/indeed-logo-768x199.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/monster-com-logo-768x126.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/ziprecruiter-blacktext.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/dice-com-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/techcrunch-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/e-financialcareers-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/jobsonthemenu-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/healthcarejobsitecom-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/jobsinlogistics-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/mediabistro-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/journalismjobs-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/salesgravy-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/talentzoo-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/techcareerscom-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/idealist-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/stackoverflow-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/usajobs-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/behance-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/IEEE_JS_LOGO.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/venturebeat-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/mashableJobBoardLogo-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/snag-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/flexjobs-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/upwork-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/careerbuilder-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/simplyhired-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/ladders-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/craigslist-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/linkedin-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/careerarc-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/college-recruiter-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/internships-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/linkup-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/jobappsonline-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/careercloud-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO Icons (Source) VALUES ('/lib/images/payscale-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209031456_SeedIconsTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209031456_SeedIconsTable', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209051837_AdjustedAgencyModel')
BEGIN
    ALTER TABLE [Agency] ADD [IronSrcId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209051837_AdjustedAgencyModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209051837_AdjustedAgencyModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209055341_FixedAgencyIndex')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'IconSrc');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [Agency] DROP COLUMN [IconSrc];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209055341_FixedAgencyIndex')
BEGIN
    ALTER TABLE [Agency] ADD [IconSrcId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209055341_FixedAgencyIndex')
BEGIN
    CREATE INDEX [IX_Agency_IconSrcId] ON [Agency] ([IconSrcId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209055341_FixedAgencyIndex')
BEGIN
    ALTER TABLE [Agency] ADD CONSTRAINT [FK_Agency_Icons_IconSrcId] FOREIGN KEY ([IconSrcId]) REFERENCES [Icons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209055341_FixedAgencyIndex')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209055341_FixedAgencyIndex', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209060443_AnotherAgencyUpdate')
BEGIN
    ALTER TABLE [Agency] DROP CONSTRAINT [FK_Agency_Icons_IconSrcId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209060443_AnotherAgencyUpdate')
BEGIN
    EXEC sp_rename N'[Agency].[IconSrcId]', N'IconsId', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209060443_AnotherAgencyUpdate')
BEGIN
    EXEC sp_rename N'[Agency].[IX_Agency_IconSrcId]', N'IX_Agency_IconsId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209060443_AnotherAgencyUpdate')
BEGIN
    ALTER TABLE [Agency] ADD CONSTRAINT [FK_Agency_Icons_IconsId] FOREIGN KEY ([IconsId]) REFERENCES [Icons] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209060443_AnotherAgencyUpdate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209060443_AnotherAgencyUpdate', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209062917_FixedAgencyIndexAgain')
BEGIN
    ALTER TABLE [Agency] DROP CONSTRAINT [FK_Agency_Icons_IconsId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209062917_FixedAgencyIndexAgain')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'IronSrcId');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Agency] DROP COLUMN [IronSrcId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209062917_FixedAgencyIndexAgain')
BEGIN
    DROP INDEX [IX_Agency_IconsId] ON [Agency];
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'IconsId');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [Agency] ALTER COLUMN [IconsId] int NOT NULL;
    CREATE INDEX [IX_Agency_IconsId] ON [Agency] ([IconsId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209062917_FixedAgencyIndexAgain')
BEGIN
    ALTER TABLE [Agency] ADD CONSTRAINT [FK_Agency_Icons_IconsId] FOREIGN KEY ([IconsId]) REFERENCES [Icons] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209062917_FixedAgencyIndexAgain')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209062917_FixedAgencyIndexAgain', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209072757_YetAnotherAngencyModelChange')
BEGIN
    ALTER TABLE [Agency] DROP CONSTRAINT [FK_Agency_Icons_IconsId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209072757_YetAnotherAngencyModelChange')
BEGIN
    DROP INDEX [IX_Agency_IconsId] ON [Agency];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209072757_YetAnotherAngencyModelChange')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'IconsId');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [Agency] DROP COLUMN [IconsId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209072757_YetAnotherAngencyModelChange')
BEGIN
    ALTER TABLE [Agency] ADD [IconSrc] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209072757_YetAnotherAngencyModelChange')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209072757_YetAnotherAngencyModelChange', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Glassdoor','https://www.glassdoor.com/index.htm','/lib/images/glassdoor.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Behance','https://www.behance.net/joblist','/lib/images/behance-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerArc','https://www.careerarc.com/','/lib/images/careerarc-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerBuilder','https://www.careerbuilder.com/','/lib/images/careerbuilder-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerCloud','https://www.careercloud.com/','/lib/images/careercloud-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CollegeRecruiter','https://www.collegerecruiter.com/','/lib/images/college-recruiter-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CraigsList','https://craigslist.org/','/lib/images/craigslist-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CulIntro','https://culintro.com/','/lib/images/culintro-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Dice','https://www.dice.com/','/lib/images/dice-com-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('efinancialcareers','https://www.efinancialcareers.com/','/lib/images/e-financialcareers-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Flexjobs','https://www.flexjobs.com/','/lib/images/flexjobs-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Healthcare Jobsite.com','https://www.healthcarejobsite.com/','/lib/images/healthcarejobsitecom-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Idealist','https://www.idealist.org/en/?type=JOB','/lib/images/idealist-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('IEEE JobSite','https://jobs.ieee.org/','/lib/images/IEEE_JS_LOGO.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Indeed','https://www.indeed.com/','/lib/images/indeed-logo-768x199.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Interships.com','https://www.internships.com/','/lib/images/interships-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('JobApplicationsOnline.com','https://www.jobapplicationsonline.com/','/lib/images/jobsappsonline-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('The Ladders','https://www.theladders.com/','/lib/images/ladders-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkedIn Jobs','https://www.linkedin.com/jobs/','/lib/images/linkedin-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkUp','https://www.linkup.com/','/lib/images/linkup-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Mashable Job Board','http://jobs.mashable.com/','/lib/images/mashableJobBoardLogo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Media Bistro','https://www.mediabistro.com/jobs/','/lib/images/mediabistro-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Monster.com','https://www.monster.com/','/lib/images/monster-com-logo-768x126.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SalesGravy','https://www.salesgravy.com/JobBoard/','/lib/images/salesgravy-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SimplyHired','https://www.simplyhired.com/','/lib/image/simplyhired-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Snagajob','https://www.snagajob.com/','/lib/image/snag-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('StackOverflow Jobs','https://stackoverflow.com/jobs/get-started','/lib/image/stackoverflow-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Talent Zoo','http://www.talentzoo.com/','/lib/image/talentzoo-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('TechCareers','https://www.techcareers.com/','/lib/image/techcareerscom-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('UpWork','https://www.upwork.com/','/lib/image/upwork-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('USAJOBS','https://www.usajobs.gov/','/lib/image/usajobs-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('ZipRecruiter','https://www.ziprecruiter.com','/lib/image/ziprecruiter-blacktext.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209073131_SeedAgencies')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209073131_SeedAgencies', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209185400_AddedNametoDocumentModel')
BEGIN
    ALTER TABLE [Document] ADD [Name] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209185400_AddedNametoDocumentModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209185400_AddedNametoDocumentModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Agency] DROP CONSTRAINT [FK_Agency_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Contact] DROP CONSTRAINT [FK_Contact_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Document] DROP CONSTRAINT [FK_Document_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Document] DROP CONSTRAINT [FK_Document_Persons_PersonId1];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Employer] DROP CONSTRAINT [FK_Employer_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    ALTER TABLE [Job] DROP CONSTRAINT [FK_Job_Persons_PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP TABLE [Persons];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Job_PersonId] ON [Job];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Interactions_PersonId] ON [Interactions];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Employer_PersonId] ON [Employer];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Document_PersonId] ON [Document];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Document_PersonId1] ON [Document];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Contact_PersonId] ON [Contact];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DROP INDEX [IX_Agency_PersonId] ON [Agency];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'PersonId');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [Job] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var19 sysname;
    SELECT @var19 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'PersonId');
    IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var19 + '];');
    ALTER TABLE [Interactions] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var20 sysname;
    SELECT @var20 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'PersonId');
    IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var20 + '];');
    ALTER TABLE [Employer] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var21 sysname;
    SELECT @var21 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Document]') AND [c].[name] = N'PersonId');
    IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Document] DROP CONSTRAINT [' + @var21 + '];');
    ALTER TABLE [Document] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var22 sysname;
    SELECT @var22 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Document]') AND [c].[name] = N'PersonId1');
    IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Document] DROP CONSTRAINT [' + @var22 + '];');
    ALTER TABLE [Document] DROP COLUMN [PersonId1];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var23 sysname;
    SELECT @var23 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contact]') AND [c].[name] = N'PersonId');
    IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Contact] DROP CONSTRAINT [' + @var23 + '];');
    ALTER TABLE [Contact] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    DECLARE @var24 sysname;
    SELECT @var24 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'PersonId');
    IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var24 + '];');
    ALTER TABLE [Agency] DROP COLUMN [PersonId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190209214124_DeletePerson')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190209214124_DeletePerson', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Job] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Interactions] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Employer] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Document] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Agency] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    CREATE INDEX [IX_Job_ApplicationUserId] ON [Job] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    CREATE INDEX [IX_Interactions_ApplicationUserId] ON [Interactions] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    CREATE INDEX [IX_Employer_ApplicationUserId] ON [Employer] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    CREATE INDEX [IX_Document_ApplicationUserId] ON [Document] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    CREATE INDEX [IX_Agency_ApplicationUserId] ON [Agency] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Agency] ADD CONSTRAINT [FK_Agency_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Document] ADD CONSTRAINT [FK_Document_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Employer] ADD CONSTRAINT [FK_Employer_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210164337_AddedApplicationUserModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190210164337_AddedApplicationUserModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210170116_EditApplicationUser')
BEGIN
    DECLARE @var25 sysname;
    SELECT @var25 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'FirstName');
    IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var25 + '];');
    ALTER TABLE [AspNetUsers] ALTER COLUMN [FirstName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190210170116_EditApplicationUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190210170116_EditApplicationUser', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190211005027_ChangedDocumentModel')
BEGIN
    ALTER TABLE [Document] ADD [RawContent] varbinary(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190211005027_ChangedDocumentModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190211005027_ChangedDocumentModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232149_DeletedDocuments')
BEGIN
    ALTER TABLE [Agency] DROP CONSTRAINT [FK_Agency_AspNetUsers_ApplicationUserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232149_DeletedDocuments')
BEGIN
    DROP TABLE [Document];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232149_DeletedDocuments')
BEGIN
    DROP INDEX [IX_Agency_ApplicationUserId] ON [Agency];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232149_DeletedDocuments')
BEGIN
    DECLARE @var26 sysname;
    SELECT @var26 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Agency]') AND [c].[name] = N'ApplicationUserId');
    IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Agency] DROP CONSTRAINT [' + @var26 + '];');
    ALTER TABLE [Agency] DROP COLUMN [ApplicationUserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232149_DeletedDocuments')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190212232149_DeletedDocuments', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Glassdoor','https://www.glassdoor.com/index.htm','/lib/images/glassdoor.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Behance','https://www.behance.net/joblist','/lib/images/behance-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerArc','https://www.careerarc.com/','/lib/images/careerarc-icon.svg.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerBuilder','https://www.careerbuilder.com/','/lib/images/careerbuilder-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerCloud','https://www.careercloud.com/','/lib/images/careercloud-icon-stroke-and-fill.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CollegeRecruiter','https://www.collegerecruiter.com/','/lib/images/college-recruiter.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CraigsList','https://craigslist.org/','/lib/images/craigslist.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CulIntro','https://culintro.com/','/lib/images/culintro.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Dice','https://www.dice.com/','/lib/images/dice-logo-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('efinancialcareers','https://www.efinancialcareers.com/','/lib/images/efinancial.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Flexjobs','https://www.flexjobs.com/','/lib/images/flexjobs-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Healthcare Jobsite.com','https://www.healthcarejobsite.com/','/lib/images/healthcarejobsitecom.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Idealist','https://www.idealist.org/en/?type=JOB','/lib/images/idealist-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('IEEE JobSite','https://jobs.ieee.org/','/lib/images/IEEE_LOGO.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Indeed','https://www.indeed.com/','/lib/images/indeed-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Interships.com','https://www.internships.com/','/lib/images/interships.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('JobApplicationsOnline.com','https://www.jobapplicationsonline.com/','/lib/images/jobsappsonline-logo (1).svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('The Ladders','https://www.theladders.com/','/lib/images/ladders.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkedIn Jobs','https://www.linkedin.com/jobs/','/lib/images/linkedin.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkUp','https://www.linkup.com/','/lib/images/linkup_logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Mashable Job Board','http://jobs.mashable.com/','/lib/images/mashable-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Media Bistro','https://www.mediabistro.com/jobs/','/lib/images/mediabistro.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Monster.com','https://www.monster.com/','/lib/images/monster.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SalesGravy','https://www.salesgravy.com/JobBoard/','/lib/images/salesgravy-logo (2).svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SimplyHired','https://www.simplyhired.com/','/lib/image/simplyhired-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Snagajob','https://www.snagajob.com/','/lib/image/snag-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('StackOverflow Jobs','https://stackoverflow.com/jobs/get-started','/lib/image/stackoverflow-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Talent Zoo','http://www.talentzoo.com/','/lib/image/talentzoo-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('TechCareers','https://www.techcareers.com/','/lib/image/techcareer-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('UpWork','https://www.upwork.com/','/lib/image/logo-upwork.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('USAJOBS','https://www.usajobs.gov/','/lib/image/USAJOBS.gov_logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('ZipRecruiter','https://www.ziprecruiter.com','/lib/image/ziprecruiter-blacktext.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190212232305_UpdateLogoPaths')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190212232305_UpdateLogoPaths', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    ALTER TABLE [Job] DROP CONSTRAINT [FK_Job_Agency_AgencyId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    DROP TABLE [Agency];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    DROP TABLE [Icons];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    DROP INDEX [IX_Job_AgencyId] ON [Job];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    DECLARE @var27 sysname;
    SELECT @var27 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'AgencyId');
    IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var27 + '];');
    ALTER TABLE [Job] DROP COLUMN [AgencyId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000323_DropAgencyTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190213000323_DropAgencyTable', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000725_SeedAgency')
BEGIN
    CREATE TABLE [Agency] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [WebSite] nvarchar(max) NULL,
        [IconSrc] nvarchar(max) NULL,
        CONSTRAINT [PK_Agency] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213000725_SeedAgency')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190213000725_SeedAgency', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Glassdoor','https://www.glassdoor.com/index.htm','/lib/images/glassdoor.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Behance','https://www.behance.net/joblist','/lib/images/behance-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerArc','https://www.careerarc.com/','/lib/images/careerarc-icon.svg.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerBuilder','https://www.careerbuilder.com/','/lib/images/careerbuilder-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerCloud','https://www.careercloud.com/','/lib/images/careercloud-icon-stroke-and-fill.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CollegeRecruiter','https://www.collegerecruiter.com/','/lib/images/college-recruiter.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CraigsList','https://craigslist.org/','/lib/images/craigslist.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CulIntro','https://culintro.com/','/lib/images/culintro.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Dice','https://www.dice.com/','/lib/images/dice-logo-icon.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('efinancialcareers','https://www.efinancialcareers.com/','/lib/images/efinancial.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Flexjobs','https://www.flexjobs.com/','/lib/images/flexjobs-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Healthcare Jobsite.com','https://www.healthcarejobsite.com/','/lib/images/healthcarejobsitecom.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Idealist','https://www.idealist.org/en/?type=JOB','/lib/images/idealist-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('IEEE JobSite','https://jobs.ieee.org/','/lib/images/IEEE_LOGO.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Indeed','https://www.indeed.com/','/lib/images/indeed-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Interships.com','https://www.internships.com/','/lib/images/internships.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('JobApplicationsOnline.com','https://www.jobapplicationsonline.com/','/lib/images/jobsappsonline-logo (1).svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('The Ladders','https://www.theladders.com/','/lib/images/ladders.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkedIn Jobs','https://www.linkedin.com/jobs/','/lib/images/linkedin.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkUp','https://www.linkup.com/','/lib/images/linkup_logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Mashable Job Board','http://jobs.mashable.com/','/lib/images/mashable-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Media Bistro','https://www.mediabistro.com/jobs/','/lib/images/mediabistro.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Monster.com','https://www.monster.com/','/lib/images/monster.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SalesGravy','https://www.salesgravy.com/JobBoard/','/lib/images/salesgravy-logo (2).svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SimplyHired','https://www.simplyhired.com/','/lib/images/simplyhired-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Snagajob','https://www.snagajob.com/','/lib/images/snag-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('StackOverflow Jobs','https://stackoverflow.com/jobs/get-started','/lib/images/stackoverflow-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Talent Zoo','http://www.talentzoo.com/','/lib/images/talentzoo-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('TechCareers','https://www.techcareers.com/','/lib/images/techcareer-logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('UpWork','https://www.upwork.com/','/lib/images/logo-upwork.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('USAJOBS','https://www.usajobs.gov/','/lib/images/USAJOBS.gov_logo.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('ZipRecruiter','https://www.ziprecruiter.com','/lib/images/ziprecruiter-blacktext.svg')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213001005_ReSeedAgency')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190213001005_ReSeedAgency', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213045755_ResetUserAssociations')
BEGIN
    ALTER TABLE [Job] ADD [ApplicationUserUserName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213045755_ResetUserAssociations')
BEGIN
    ALTER TABLE [Interactions] ADD [ApplicationUserUserName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213045755_ResetUserAssociations')
BEGIN
    ALTER TABLE [Employer] ADD [ApplicationUserUserName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213045755_ResetUserAssociations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190213045755_ResetUserAssociations', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    EXEC sp_rename N'[Job].[ApplicationUserUserName]', N'ApplicationUserName', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    EXEC sp_rename N'[Interactions].[ApplicationUserUserName]', N'ApplicationUserName', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    EXEC sp_rename N'[Employer].[ApplicationUserUserName]', N'ApplicationUserName', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    ALTER TABLE [Contact] ADD [ApplicationUserId] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    ALTER TABLE [Contact] ADD [ApplicationUserName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    CREATE INDEX [IX_Contact_ApplicationUserId] ON [Contact] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    ALTER TABLE [Contact] ADD CONSTRAINT [FK_Contact_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190213054626_AdjustedUserModelAssociations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190213054626_AdjustedUserModelAssociations', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214194944_AddedInteractionTypeNameToInteractions')
BEGIN
    DECLARE @var28 sysname;
    SELECT @var28 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'ApplicationUserName');
    IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var28 + '];');
    ALTER TABLE [Job] DROP COLUMN [ApplicationUserName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214194944_AddedInteractionTypeNameToInteractions')
BEGIN
    DECLARE @var29 sysname;
    SELECT @var29 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employer]') AND [c].[name] = N'ApplicationUserName');
    IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [Employer] DROP CONSTRAINT [' + @var29 + '];');
    ALTER TABLE [Employer] DROP COLUMN [ApplicationUserName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214194944_AddedInteractionTypeNameToInteractions')
BEGIN
    EXEC sp_rename N'[Interactions].[ApplicationUserName]', N'InteractionTypeName', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214194944_AddedInteractionTypeNameToInteractions')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190214194944_AddedInteractionTypeNameToInteractions', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_InteractionTypes_InteractionTypesId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    DROP INDEX [IX_Interactions_InteractionTypesId] ON [Interactions];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    DECLARE @var30 sysname;
    SELECT @var30 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'InteractionTypesId');
    IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var30 + '];');
    ALTER TABLE [Interactions] DROP COLUMN [InteractionTypesId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    ALTER TABLE [Interactions] ADD [TypeId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    CREATE INDEX [IX_Interactions_TypeId] ON [Interactions] ([TypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_InteractionTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [InteractionTypes] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214210256_SwitchInteractionIdForName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190214210256_SwitchInteractionIdForName', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214214457_KilledInteractiontypes')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_InteractionTypes_TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214214457_KilledInteractiontypes')
BEGIN
    DROP TABLE [InteractionTypes];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214214457_KilledInteractiontypes')
BEGIN
    DROP INDEX [IX_Interactions_TypeId] ON [Interactions];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214214457_KilledInteractiontypes')
BEGIN
    DECLARE @var31 sysname;
    SELECT @var31 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'TypeId');
    IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var31 + '];');
    ALTER TABLE [Interactions] DROP COLUMN [TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214214457_KilledInteractiontypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190214214457_KilledInteractiontypes', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214224420_AddedNavPropForContactsToAppUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190214224420_AddedNavPropForContactsToAppUser', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214225659_AddedUserForeignKeyToContact')
BEGIN
    DECLARE @var32 sysname;
    SELECT @var32 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contact]') AND [c].[name] = N'ApplicationUserName');
    IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [Contact] DROP CONSTRAINT [' + @var32 + '];');
    ALTER TABLE [Contact] DROP COLUMN [ApplicationUserName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190214225659_AddedUserForeignKeyToContact')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190214225659_AddedUserForeignKeyToContact', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190215174012_AddedToDoActivity')
BEGIN
    ALTER TABLE [Interactions] ADD [ToDo] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190215174012_AddedToDoActivity')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190215174012_AddedToDoActivity', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190215204957_RemovedDefaultFromInteractioToDo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190215204957_RemovedDefaultFromInteractioToDo', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190215223009_AddedFinishedPropertyToInteraction')
BEGIN
    ALTER TABLE [Interactions] ADD [Finished] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190215223009_AddedFinishedPropertyToInteraction')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190215223009_AddedFinishedPropertyToInteraction', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220171803_AssociateInteractionsWithContacts')
BEGIN
    ALTER TABLE [Interactions] ADD [ContactId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220171803_AssociateInteractionsWithContacts')
BEGIN
    CREATE INDEX [IX_Interactions_ContactId] ON [Interactions] ([ContactId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220171803_AssociateInteractionsWithContacts')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_Contact_ContactId] FOREIGN KEY ([ContactId]) REFERENCES [Contact] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220171803_AssociateInteractionsWithContacts')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190220171803_AssociateInteractionsWithContacts', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220180140_AdjustedInteractionModel')
BEGIN
    ALTER TABLE [Interactions] DROP CONSTRAINT [FK_Interactions_Job_JobId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220180140_AdjustedInteractionModel')
BEGIN
    DECLARE @var33 sysname;
    SELECT @var33 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Interactions]') AND [c].[name] = N'JobId');
    IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [Interactions] DROP CONSTRAINT [' + @var33 + '];');
    ALTER TABLE [Interactions] ALTER COLUMN [JobId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220180140_AdjustedInteractionModel')
BEGIN
    ALTER TABLE [Interactions] ADD CONSTRAINT [FK_Interactions_Job_JobId] FOREIGN KEY ([JobId]) REFERENCES [Job] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220180140_AdjustedInteractionModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190220180140_AdjustedInteractionModel', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220183216_AddContactToInteraction')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190220183216_AddContactToInteraction', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220200039_turnedEmployerIdOnContactToNullable')
BEGIN
    ALTER TABLE [Contact] DROP CONSTRAINT [FK_Contact_Employer_EmployerId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220200039_turnedEmployerIdOnContactToNullable')
BEGIN
    DECLARE @var34 sysname;
    SELECT @var34 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contact]') AND [c].[name] = N'EmployerId');
    IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [Contact] DROP CONSTRAINT [' + @var34 + '];');
    ALTER TABLE [Contact] ALTER COLUMN [EmployerId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220200039_turnedEmployerIdOnContactToNullable')
BEGIN
    ALTER TABLE [Contact] ADD CONSTRAINT [FK_Contact_Employer_EmployerId] FOREIGN KEY ([EmployerId]) REFERENCES [Employer] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190220200039_turnedEmployerIdOnContactToNullable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190220200039_turnedEmployerIdOnContactToNullable', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221174227_RemovedEmployerNotNullFromJob')
BEGIN
    ALTER TABLE [Job] DROP CONSTRAINT [FK_Job_Employer_EmployerId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221174227_RemovedEmployerNotNullFromJob')
BEGIN
    DECLARE @var35 sysname;
    SELECT @var35 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'EmployerId');
    IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var35 + '];');
    ALTER TABLE [Job] ALTER COLUMN [EmployerId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221174227_RemovedEmployerNotNullFromJob')
BEGIN
    ALTER TABLE [Job] ADD CONSTRAINT [FK_Job_Employer_EmployerId] FOREIGN KEY ([EmployerId]) REFERENCES [Employer] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221174227_RemovedEmployerNotNullFromJob')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190221174227_RemovedEmployerNotNullFromJob', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221183348_AddedDescriptionToEmployer')
BEGIN
    ALTER TABLE [Employer] ADD [Description] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190221183348_AddedDescriptionToEmployer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190221183348_AddedDescriptionToEmployer', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/internships.svg' WHERE Id = 16
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/simplyhired-logo.svg' WHERE Id =25
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/snag-logo.svg' WHERE Id = 26
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/stackoverflow-logo.svg' WHERE Id = 27
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/talentzoo-logo.svg' WHERE Id = 28
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/techcareer-logo.svg' WHERE Id = 29
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/logo-upwork.svg' WHERE Id = 30
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/USAJOBS.gov_logo.svg' WHERE Id = 31
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/ziprecruiter-blacktext.svg' WHERE Id = 32
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    INSERT INTO Agency (Name, Website, IconSrc) VALUES ('AngelList', 'https://angel.co/', '/lib/images/angellist-logo.svg' )
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226004549_UpdateAgencySeed')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190226004549_UpdateAgencySeed', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226011118_FixTalentZooLogo')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/talentzoo-logo (1).svg' WHERE Id = 28
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226011118_FixTalentZooLogo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190226011118_FixTalentZooLogo', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226154033_ChangedPhoneOnContactAndJobNumber')
BEGIN
    DECLARE @var36 sysname;
    SELECT @var36 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Job]') AND [c].[name] = N'Number');
    IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [Job] DROP CONSTRAINT [' + @var36 + '];');
    ALTER TABLE [Job] ALTER COLUMN [Number] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226154033_ChangedPhoneOnContactAndJobNumber')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190226154033_ChangedPhoneOnContactAndJobNumber', N'2.2.0-rtm-35687');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226155139_FixJobsOnlineLogo')
BEGIN
    UPDATE Agency SET IconSrc = '/lib/images/jobappsonline-logo (1).svg' WHERE Id = 17
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190226155139_FixJobsOnlineLogo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190226155139_FixJobsOnlineLogo', N'2.2.0-rtm-35687');
END;

GO

