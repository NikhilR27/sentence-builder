USE master;

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'SentenceBuilderDb')
    BEGIN
        CREATE DATABASE SentenceBuilderDb;
    END;

USE SentenceBuilderDb;

create table Sentence
(
    Id int identity
        constraint Sentence_pk
            primary key,
    SentenceText varchar(100) not null
)

create table WordType
(
    Id int
        constraint WordType_pk
            primary key,
    Description varchar(100) not null
)

create table Word
(
    Id int identity
        constraint Word_pk
            primary key,
    WordText varchar(100) not null,
    WordTypeId int not null
        constraint Word_WordType_Id_fk
            references WordType
)

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (11,
        'Exclamation');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (10,
        'Determiner');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (9,
        'Preposition');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (8,
        'Pronoun');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (7,
        'Adverb');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (6,
        'Adjective');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (5,
        'Verb');

INSERT
INTO
    SentenceBuilderDb.dbo.WordType (id,
                                    description)
VALUES (4,
        'Noun');
-- Insert Word entries for WordType: Exclamation
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Wow',
        11);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Oh my!',
        11);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Yay',
        11);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Hooray',
        11);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Bravo',
        11);
-- Insert Word entries for WordType: Determiner
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('The',
        10);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('A',
        10);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('An',
        10);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Some',
        10);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Any',
        10);
-- Insert Word entries for WordType: Preposition
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('In',
        9);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('On',
        9);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Under',
        9);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Between',
        9);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Across',
        9);
-- Insert Word entries for WordType: Pronoun
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('I',
        8);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('You',
        8);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('He',
        8);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('She',
        8);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('They',
        8);
-- Insert Word entries for WordType: Adverb
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Quickly',
        7);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Slowly',
        7);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Loudly',
        7);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Softly',
        7);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Suddenly',
        7);
-- Insert Word entries for WordType: Adjective
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Beautiful',
        6);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Small',
        6);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Green',
        6);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Happy',
        6);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Energetic',
        6);
-- Insert Word entries for WordType: Verb
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Run',
        5);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Jump',
        5);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Swim',
        5);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Sing',
        5);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Dance',
        5);
-- Insert Word entries for WordType: Noun
INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Cat',
        4);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Dog',
        4);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Tree',
        4);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Car',
        4);

INSERT
INTO
    SentenceBuilderDb.dbo.Word (WordText,
                                WordTypeId)
VALUES ('Book',
        4);
