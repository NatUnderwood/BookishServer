CREATE TABLE BarcodeUser (
	Barcode CHAR(12) PRIMARY KEY,
	UserId INT ,
	ReturnDate DATE NOT NULL,
	CONSTRAINT BarcodeConstraint FOREIGN KEY (Barcode) REFERENCES BarcodeBook
	);