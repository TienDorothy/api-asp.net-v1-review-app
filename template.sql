INSERT INTO Country (Name) VALUES ('Kanto'), ('Saffron City'), ('Millet Town');

-- Insert into Table Owner
INSERT INTO Owner (FirstName, LastName, Gym, CountryId) 
VALUES ('Jack', 'London', 'Brocks Gym', 1), 
       ('Harry', 'Potter', 'Mistys Gym', 2), 
       ('Ash', 'Ketchum', 'Ashs Gym', 3);

-- Insert into Table Category
INSERT INTO Category (Name) VALUES ('Electric'), ('Water'), ('Leaf');

-- Insert into Table Pokemon
INSERT INTO Pokemon (Name, BirthDate) 
VALUES ('Pikachu', '1903-01-01'), 
       ('Squirtle', '1903-01-01'), 
       ('Venasuar', '1903-01-01');

-- Insert into Table Reviewer
INSERT INTO Reviewer (FirstName, LastName) 
VALUES ('Teddy', 'Smith'), 
       ('Taylor', 'Jones'), 
       ('Jessica', 'McGregor');

-- Insert into Table Review
INSERT INTO Review (Title, Text, Rating, ReviewerId, PokemonId) 
VALUES ('Pikachu', 'Pickahu is the best pokemon, because it is electric', 5, 1, 1), 
       ('Pikachu', 'Pickachu is the best a killing rocks', 5, 2, 1), 
       ('Pikachu', 'Pickchu, pickachu, pikachu', 1, 3, 1),
       ('Squirtle', 'squirtle is the best pokemon, because it is electric', 5, 1, 2), 
       ('Squirtle', 'Squirtle is the best a killing rocks', 5, 2, 2), 
       ('Squirtle', 'squirtle, squirtle, squirtle', 1, 3, 2),
       ('Veasaur', 'Venasuar is the best pokemon, because it is electric', 5, 1, 3), 
       ('Veasaur', 'Venasuar is the best a killing rocks', 5, 2, 3), 
       ('Veasaur', 'Venasuar, Venasuar, Venasuar', 1, 3, 3);

-- Insert into Table PokemonCategory
INSERT INTO PokemonCategory (PokemonId, CategoryId) 
VALUES (1, 1), 
       (2, 2), 
       (3, 3);

-- Insert into Table PokemonOwner
INSERT INTO PokemonOwner (PokemonId, OwnerId) 
VALUES (1, 1), 
       (2, 2), 
       (3, 3);