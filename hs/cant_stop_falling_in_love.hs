import Euterpea

shared = [
    -- Wise men / Shall I / Take my
    f 5 hn,
    c 6 hn,

    -- say only / stay? Would it / hand, take my
    f 5 $ hn + qn,
    g 5 en,
    a 5 en,

    -- fools rush / be a / whole life
    as 5 hn,
    a 5 hn,

    -- in, But / sin if / too. For
    g 5 $ hn + qn + en,
    c 5 en,

    -- I can't / I can't / I can't
    d 5 hn,
    e 5 hn,

    -- help falling in / help falling in / help falling in
    f 5 hn,
    g 5 $ hn / 3,
    a 5 $ hn / 3,
    as 5 $ hn / 3,

    -- love with / love with / love with
    a 5 hn,
    g 5 hn
    ]

verse = line $ shared ++ [f 5 wn]

bridge = line [
    -- Live a river flows
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- surely to the sea,
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- Darling, so it goes.
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- Some things are meant to
    c 6 qn,
    c 6 $ qn + en,
    a 5 en,
    c 6 en,
    a 5 en,

    -- be.
    as 5 wn
    ]

ending = line $ shared ++ [
    -- you. For
    f 5 $ hn + qn + en,
    c 5 en,

    -- I can't
    d 5 hn,
    e 5 hn,

    -- help falling in
    f 5 hn,
    g 5 $ hn / 3,
    a 5 $ hn / 3,
    as 5 $ hn / 3,

    -- love with
    a 5 hn,
    g 5 hn,

    -- you.
    f 5 bn
    ]

{--
bridge = line [
    -- Live a river flows
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- surely to the sea,
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- Darling, so it goes.
    e 5 en,
    a 5 en,
    c 6 en,
    e 6 en,
    d 6 hn,

    -- Some things are meant to
    c 6 qn,
    c 6 $ qn + en,
    a 5 en,
    c 6 en,
    a 5 en,

    -- be.
    as 5 wn]
--}

cantHelp = verse :+: verse :+: bridge :+: ending

main = play $ Modify (Tempo 2) $ Modify (Instrument RhodesPiano) cantHelp
