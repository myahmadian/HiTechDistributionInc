# HiTech Distribution Inc. Project Overview

This repository contains the source code and related files for the HiTech Distribution Inc. project.
The project is structured in a typical C# solution format and includes several SQL scripts, a PDF document detailing the project requirements,
and numerous C# files organized into various layers such as Business Logic Layer (BLL), Data Access Layer (DAL), and others.

# Contents

- .git-related Files: Version control related configurations.
- SQL Scripts: Scripts like `2021.sql`, `script.sql`, and `Script_Dec_8.sql` for database operations.
- PDF Document: Contains the project requirements or specifications.
- C# Project Files: Includes the main project file `HiTechDistributionInc.csproj`, solution file `HiTechDistributionInc.sln`, and various source code files.

# Key Directories

- BLL (Business Logic Layer): Contains C# class files defining business entities and their validation logic. Key entities include `Author`, `Book`, `Customer`, `Employee`, `Inventory`, `Order`, `Publisher`, `Role`, `UserAccount`, and their corresponding validators.
- DAL (Data Access Layer): typically contains data handling and database interaction logic.

# Example SQL Schema (Based on BLL Classes)

This section provides an example SQL schema based on the `Author` and `Book` classes from the BLL folder. It's important to note that these are educated guesses and might need adjustments based on the actual class definitions.

# Database Creation
```sql
CREATE DATABASE HiTechDistributionDB;
```

# Tables Creation
```sql
CREATE TABLE Author (
    Id INT PRIMARY KEY,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Email VARCHAR(255)
);

CREATE TABLE Book (
    Id INT PRIMARY KEY,
    Isbn VARCHAR(255),
    Title VARCHAR(255),
    Category INT, 
    YearPublished INT,
    PublisherId INT
);

CREATE TABLE AuthorBook (
    AuthorId INT,
    BookId INT,
    PRIMARY KEY (AuthorId, BookId),
    FOREIGN KEY (AuthorId) REFERENCES Author(Id),
    FOREIGN KEY (BookId) REFERENCES Book(Id)
);
```

# Discussion and Analysis

Throughout the chat, we discussed the structure and contents of the uploaded ZIP file, focusing on understanding the roles of various files and directories in the project.
We examined the `Author` and `Book` class files in detail to infer the database schema.
The conversation included guidance on writing SQL queries for creating a database schema based on the C# class structures.

# Additional Notes

- This README provides a high-level overview and might not cover all details of the project.
- The SQL schema provided is based on assumptions and partial information; it should be verified and adjusted according to the actual class definitions and project requirements.
