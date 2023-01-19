IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Course] (
    [Id] int NOT NULL IDENTITY,
    [CourseName] nvarchar(max) NOT NULL,
    [ShortCourseDescription] nvarchar(200) NOT NULL,
    [LongCourseDescription] nvarchar(max) NOT NULL,
    [TargetAudience] nvarchar(max) NOT NULL,
    [Targets] nvarchar(max) NOT NULL,
    [Requierments] nvarchar(max) NOT NULL,
    [Level] int NOT NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedBy] nvarchar(max) NOT NULL,
    [UpdatedDate] datetime2 NULL,
    [DeletedBy] nvarchar(max) NOT NULL,
    [DeletedDate] datetime2 NULL,
    [isDeleted] bit NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230119193446_Create Users and Course table', N'7.0.2');
GO

COMMIT;
GO

