"""
https://www.goodhousekeeping.com/life/parenting/a31401884/gender-neutral-baby-names/
"""

MIN_BACKSTORY_LENGTH = 170

# Using some kind of brown corpus might make verb checking easier
# TODO
# - Create THEM var and THEY var for you following words
# - Rename Tenses
TENSES = [
    ("yourself", "themselves"),
    ("yours ", "theirs "),
    ("your ", "their "),
    ("Your ", "Their "),
    ("You", "They"),
    ("you.", "them."),
    ("you were", "they were"),
    ("you how", "them how"),
    ("you to", "them to"),
]

NAMES = [
    "Bellamy",
    "Charlie",
    "Dakota",
    "Denver",
    "Emerson",
    "Finley",
    "Justice",
    "River",
    "Skyler",
    "Tatum",
    "Jessie",
    "Marion",
    "Jackie",
    "Alva",
    "Ollie",
    "Jodie",
    "Cleo",
    "Kerry",
    "Frankie",
    "Guadalupe",
    "Carey",
    "Tommie",
    "Angel",
    "Hollis",
    "Sammie",
    "Jamie",
    "Kris",
    "Robbie",
    "Tracy",
    "Merrill",
    "Noel",
    "Rene",
    "Johnnie",
    "Ariel",
    "Jan",
    "Casey",
    "Jackie",
    "Kerry",
    "Jodie",
    "Finley",
    "Skylar",
    "Justice",
    "Rene",
    "Darian",
    "Frankie",
    "Oakley",
    "Robbie",
    "Remy",
    "Milan",
    "Jaylin",
    "Devan",
    "Armani",
    "Charlie",
    "Stevie",
    "Channing",
    "Gerry",
    "Monroe",
    "Kirby",
    "Azariah",
    "Santana",
]