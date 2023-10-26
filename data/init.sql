-- public.word_type definition

-- Drop table

-- DROP TABLE public.word_type;

CREATE TABLE public.word_type (
                                  id int4 NOT NULL,
                                  description varchar NOT NULL,
                                  CONSTRAINT id_pk PRIMARY KEY (id)
);


-- public.sentence definition

-- Drop table

-- DROP TABLE public.sentence;

CREATE TABLE public.sentence (
                                 id serial4 NOT NULL,
                                 sentence_text varchar NOT NULL
);


-- public.word definition

-- Drop table

-- DROP TABLE public.word;

CREATE TABLE public.word (
                             id int4 NOT NULL,
                             word_text varchar NOT NULL,
                             word_type_id int4 NOT NULL,
                             CONSTRAINT word_fk FOREIGN KEY (word_type_id) REFERENCES public.word_type(id)
);

INSERT INTO word_type (id, description) VALUES (11, 'Exclamation');
INSERT INTO word_type (id, description) VALUES (10, 'Determiner');
INSERT INTO word_type (id, description) VALUES (9, 'Preposition');
INSERT INTO word_type (id, description) VALUES (8, 'Pronoun');
INSERT INTO word_type (id, description) VALUES (7, 'Adverb');
INSERT INTO word_type (id, description) VALUES (6, 'Adjective');
INSERT INTO word_type (id, description) VALUES (5, 'Verb');
INSERT INTO word_type (id, description) VALUES (4, 'Noun');

-- Insert Word entries for WordType: Exclamation
INSERT INTO Word (id, word_text, word_type_id) VALUES (1, 'Wow', 11);
INSERT INTO Word (id, word_text, word_type_id) VALUES (2, 'Yay', 11);
INSERT INTO Word (id, word_text, word_type_id) VALUES (3, 'Bravo', 11);

-- Insert Word entries for WordType: Determiner
INSERT INTO Word (id, word_text, word_type_id) VALUES (4, 'The', 10);
INSERT INTO Word (id, word_text, word_type_id) VALUES (5, 'A', 10);
INSERT INTO Word (id, word_text, word_type_id) VALUES (6, 'An', 10);

-- Insert Word entries for WordType: Preposition
INSERT INTO Word (id, word_text, word_type_id) VALUES (7, 'In', 9);
INSERT INTO Word (id, word_text, word_type_id) VALUES (8, 'On', 9);
INSERT INTO Word (id, word_text, word_type_id) VALUES (9, 'Under', 9);

-- Insert Word entries for WordType: Pronoun
INSERT INTO Word (id, word_text, word_type_id) VALUES (10, 'I', 8);
INSERT INTO Word (id, word_text, word_type_id) VALUES (11, 'You', 8);
INSERT INTO Word (id, word_text, word_type_id) VALUES (12, 'He', 8);

-- Insert Word entries for WordType: Adverb
INSERT INTO Word (id, word_text, word_type_id) VALUES (13, 'Quickly', 7);
INSERT INTO Word (id, word_text, word_type_id) VALUES (14, 'Softly', 7);
INSERT INTO Word (id, word_text, word_type_id) VALUES (15, 'Suddenly', 7);

-- Insert Word entries for WordType: Adjective
INSERT INTO Word (id, word_text, word_type_id) VALUES (16, 'Beautiful', 6);
INSERT INTO Word (id, word_text, word_type_id) VALUES (17, 'Green', 6);
INSERT INTO Word (id, word_text, word_type_id) VALUES (18, 'Happy', 6);

-- Insert Word entries for WordType: Verb
INSERT INTO Word (id, word_text, word_type_id) VALUES (19, 'Run', 5);
INSERT INTO Word (id, word_text, word_type_id) VALUES (20, 'Swim', 5);
INSERT INTO Word (id, word_text, word_type_id) VALUES (21, 'Dance', 5);

-- Insert Word entries for WordType: Noun
INSERT INTO Word (id, word_text, word_type_id) VALUES (22, 'Cat', 4);
INSERT INTO Word (id, word_text, word_type_id) VALUES (23, 'Tree', 4);
INSERT INTO Word (id, word_text, word_type_id) VALUES (24, 'Book', 4);
