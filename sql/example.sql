CREATE TABLE IF NOT EXISTS players(
    id INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,    -- (Auto-increment)
    username VARCHAR(32) NOT NULL UNIQUE,               -- (Required, and unique)
    level INT CHECK (level BETWEEN 1 and 99),           -- (Must be in range [1, 99])
    CHECK (char_length(username) >= 3)                  -- ("username" field must be at least 3 characters long)
);

INSERT INTO players (username, level)
    VALUES
        ('Lunar', 97),
        ('Bob', 10),
        ('Charlie', 7);

SELECT * FROM players;

-- INSERT INTO players (username, level)
--     VALUES
--         ('Temp User', NULL);
