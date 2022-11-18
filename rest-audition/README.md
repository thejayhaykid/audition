# REST API
Using an API framework of your choice. Create a REST API that implements the following...

## Domain
Create a REST API that models a *library*.

A *library* is a simple a collection of *books*.

A *book* has the following properties:
* ISBN (10-13 Digits)
* Title (Alphanumeric, Spaces and Special Characters Allowed)
* Author
* Genre ( Nonfiction | Fiction )

A *book* has an *Author*.

An *Author* has the following properties:
* Id (UUID)
* First Name (Alphabetical, 100 character max)
* Last Name (Alphabetical, 100 characters max)
* Date Of Birth

## Functionality
1. Lookup a book by its ISBN.
2. Add a new book to the collection.
3. Delete a book from the collection.
4. Search for a list of books by:
    * AuthorId
    * Genre
    * Title Substring

## Implementation
Feel free to use an in-memory collection of books rather than writing to a file or database.
