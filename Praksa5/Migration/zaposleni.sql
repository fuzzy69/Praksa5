CREATE TABLE dbo.ZAPOSLENI (
	Maticni_Broj_Zaposlenog bigint NOT NULL,
	Prezime_Zaposlenog nvarchar(100) NOT NULL,
	Ime_Zaposlenog nvarchar(100) NOT NULL,
	Ime_Jednog_Roditelja nvarchar(100) NULL,
	Adresa nvarchar(255) NULL,
	Sifra_Mesto int NULL,
	Email nvarchar(255) NULL
	CONSTRAINT PK_ZAPOSLENI PRIMARY KEY CLUSTERED (Maticni_Broj_Zaposlenog ASC)
)