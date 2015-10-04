## Database Systems - Overview - Homework

### 1.  What database models do you know?

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.

##### Logical data models:

* Hierarchical database model (tree)
* Network model (graph)
* Relational model (table)
* Object-oriented model
* Entity–relationship model
* Enhanced entity–relationship model
* Document model
* Entity–attribute–value model
* Star schema

##### Physical data models:

* Inverted index
* Flat file

##### Other models:

* Associative model
* Multidimensional model

### 2.  Which are the main functions performed by a Relational Database Management System (RDBMS)?

A relational database management system (RDBMS) is a database management system (DBMS) that is based on the relational model 

RDBMS systems typically implement
* Creating / altering / deleting tables and relationships between them (database schema)
* Adding, changing, deleting, searching and retrieving of data stored in the tables
* Support for the SQL language
* Transaction management (optional)

### 3.  Define what is "table" in database terms.

A database table is a collection of related data held in a structured format within a database. It consists of columns and rows.
In relational databases a table is a set of data elements (values) using a model of:
* vertical columns
* horizontal rows
* and the cell being the unit where a row and column intersect.

### 4.  Explain the difference between a primary and a foreign key.

In SQL Server, there are two keys - primary key and foreign key which seems identical, but actually both are different in features and behaviours. 

Primary Key | Foreign Key
-----------------------------------------------------|-----------------------------------------------------
Primary key uniquely identify a record in the table. | Foreign key is a field in the table that is primary key in another table.
Primary Key can't accept null values. | Foreign key can accept multiple null value.
By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index. | Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
We can have only one Primary key in a table. | We can have more than one foreign key in a table.   

### 5.  Explain the different kinds of relationships between tables in relational databases.

A relationship, in the context of databases, is a situation that exists between two relational database tables when one table has a foreign key that references the primary key of the other table. Relationships allow relational databases to split and store data in different tables, while linking disparate data items.

The relationships between tables are based on interconnections: primary key / foreign key. The foreign key is an identifier of a record located in another table (usually its primary key).

Three types of relationships can exist between tables in a database: _one-to-many_, _one-to-one_, and _many-to-many_.

##### One-to-many
A one-to-many relationship is by far the most common type of relationship. In a one-to-many relationship, a record in one table can have many related records in another table. The primary key table contains only one record that relates to none, one, or many records in the related table.

##### Many-to-many
In a many-to-many relationship, records in both tables have matching records in the other table. Each primary key value relates to only one (or no) record in the related table. These relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

##### One-to-one
In a one-to-one relationship, each record in the table on the one side of the relationship can have only one matching record in the table on the many side of the relationship. Each primary key value relates to only one (or no) record in the related table. This relationship is not common and is used only in special circumstances.
This kind of relationship is like Inheritance in OOP.

_Examples:_

![Relationships](http://fms-itskills.ncl.ac.uk/db/ER.png)

##### Self relationship (ïðèìêà)
This is used when a table needs to have a relationship with itself. The primary / foreign key relationships can point to one and the same table.

Example: employees in a company have a manager, who is also an employee.

![Self-relationship](http://docs.telerik.com/data-access/images/developer-guide-domain-model-naming-settings-nav-props-names-handling-selfref-1m-010.png)

### 6.  When is a certain database schema normalized?

A database schema is a way to logically group objects such as tables, views, stored procedures etc. Think of a schema as a container of objects.
The relational schema describes the structure of the database. Doesn't contain data, but metadata.

Database normalization is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.
Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones.

Advantages                                       | Disadvantages
-------------------------------------------------|-------------------------------------------------
Smaller database: by eliminating duplicate data. | More tables to join: by spreading data into more tables.
Better performance.                              | Tables contain codes instead of real data.

### 7.  What are database integrity constraints and when are they used?

Integrity constraints are used to ensure accuracy and consistency of data in a relational database. Data integrity is handled in a relational database through the concept of referential integrity. Many types of integrity constraints play a role in referential integrity (RI).

##### Primary Key Constraints
Primary key is the term used to identify one or more columns in a table that make a row of data unique. Although the primary key typically consists of one column in a table, more than one column can comprise the primary key.

_Ensures that the primary key of a table has unique value for each table row._

##### Unique Constraints
A unique column constraint in a table is similar to a primary key in that the value in that column for every row of data in the table must have a unique value. Although a primary key constraint is placed on one column, you can place a unique constraint on another column even though it is not actually for use as the primary key.

_Ensures that all values in a certain column (or a group of columns) are unique._

##### Foreign Key Constraints
A foreign key is a column in a child table that references a primary key in the parent table. A foreign key constraint is the main mechanism used to enforce referential integrity between tables in a relational database. A column defined as a foreign key is used to reference a column defined as a primary key in another table. 

_Ensures that the value in given column is a key from another table._

##### NOT NULL Constraints
The NOT NULL constraint enforces a column to NOT accept NULL values.
The NOT NULL constraint enforces a field to always contain a value. This means that you cannot insert a new record, or update a record without adding a value to this field.

##### Check Constraints
Check (CHK) constraints can be utilized to check the validity of data entered into particular table columns. Check constraints are used to provide back-end database edits, although edits are commonly found in the front-end application as well. General edits restrict values that can be entered into columns or objects, whether within the database itself or on a front-end application.

_Ensures that values in a certain column meet some predefined condition._

### 8.  Point out the pros and cons of using indexes in a database.

A database index is a data structure that improves the speed of data retrieval operations on a database table at the cost of additional writes and storage space to maintain the index data structure. Indexes are used to quickly locate data without having to search every row in a database table every time a database table is accessed. Indexes can be created using one or more columns of a database table.

**Advantages**: use an index for quick access to a database table specific information.

**Disadvantages**: too index will affect the speed of update and insert, because it requires the same update each index file.

### 9.  What's the main purpose of the SQL language?

SQL (Structured Query Language) is standardized declarative language for manipulation of relational databases.
SQL-99 is currently in use in most databases
SQL language supports:
* Creating, altering, deleting tables and other objects in the database
* Searching, retrieving, inserting, modifying and deleting table data (rows)

Purpose of **SQL** is to provide a **Structured** way by which one can **Query** information in database using a standard **Language**.

### 10.  What are transactions used for?

Transactions are a sequence of database operations which are executed as a single unit:
* Either all of them execute successfully
* Or none of them is executed at all

Transactions guarantee the consistency and the integrity of the database.

Transactions have four key properties that are abbreviated ACID (Atomic Consistent Isolated Durability).

_Example:_
A bank transfer from one account into another (withdrawal + deposit). If either the withdrawal or the deposit fails the entire operation should be cancelled

### 11.  What is a NoSQL database?

A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.

A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote. These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. The most popular emerging non-relational database is called NoSQL (Not Only SQL).

NoSQL databases use document-based model (non-relational).

### 12.  Explain the classical non-relational data models.

* Document model (e.g. MongoDB, CouchDB) - Set of documents, e.g. JSON strings

* Key-value model (e.g. Redis) - Set of key-value pairs

* Hierarchical key-value - Hierarchy of key-value pairs

* Wide-column model (e.g. Cassandra) - Key-value model with schema

* Object model (e.g. Cache) - Set of OOP-style objects

### 13.  Give few examples of NoSQL databases and their pros and cons.

##### Redis
Ultra-fast in-memory data structures server

Advantages                                       | Disadvantages
-------------------------------------------------|-------------------------------------------------
Lightening fast. | Memory only.
Replication possible. | You can have slaves, but it's not distributed yet. Although they intend to add it in future.
Cool datastructures available within realm of key-value. | 

##### MongoDB
Mature and powerful JSON-document database

Advantages                                       | Disadvantages
-------------------------------------------------|-------------------------------------------------
Enables horizontal scalability by using a technique called sharding. | Very unreliable. No single server durability.
Provides ACID properties at the document level as in the case of relational databases. | Indexes take up a lot of RAM. They are B-tree indexes and if you have many, you can run out of system resources really fast.


##### CouchDB
JSON-based document database with REST API

Advantages                                       | Disadvantages
-------------------------------------------------|-------------------------------------------------
Very persistent, no power failure, system crash will do anything to your data. | Couch maintains a different document for every update you make.
Everything is HTTP. You can serve a CouchApp from database itself using views. | 
Replication is easy, and can be uni or bi-directional. | 

##### Cassandra
Distributed wide-column database

Some of the strong points of Cassandra are:
* Highly scalable and highly available with no single point of failure.
* Very high write throughput and good read throughput. 
* Flexible schemal. 