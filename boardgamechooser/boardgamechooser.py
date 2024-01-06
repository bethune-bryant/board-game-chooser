import argparse
import csv
from randomwrapy import rnumlistwithreplacement as rand


def cli():
    parser = argparse.ArgumentParser(description="Choose a boardgame.")
    parser.add_argument("collection", help="CSV Collection File")
    parser.add_argument("--players", required=True, type=int, help="Number of Players")
    parser.add_argument(
        "--age_youngest",
        default=None,
        type=int,
        help="Age of the youngest player in years.",
    )
    parser.add_argument(
        "--playtime_max",
        default=None,
        type=int,
        help="Maximum desired playtime in minutes.",
    )
    parser.add_argument("--all", action="store_true", help="List all possible games.")
    parser.add_argument(
        "--players_type",
        default="minmax",
        choices=["minmax", "bggbest", "bggrec"],
        help="Which player counts to use (default: %(default)s)",
    )

    return parser.parse_args()


def gameToString(game):
    return "{}, {}-{} Players, {} Years Old, {}-{} Minutes, Recommended for {} Players, Best for {} Players".format(
        game["objectname"],
        game["minplayers"],
        game["maxplayers"],
        game["bggrecagerange"],
        game["minplaytime"],
        game["maxplaytime"],
        game["bggrecplayers"],
        game["bggbestplayers"],
    )


def agerangetominage(agerange):
    rangesymbol = "–"
    if agerange:
        if agerange[-1] == "+":
            return int(agerange[0:-1])
        elif rangesymbol in agerange:
            return int(agerange.split(rangesymbol)[0])
    else:
        return 0


def choose(
    collection,
    players,
    youngest=None,
    max_playtime=None,
    all=False,
    players_type="minmax",
):
    collection = [game for game in collection if game["itemtype"] == "standalone"]
    if players_type == "minmax":
        collection = [
            game
            for game in collection
            if int(game["minplayers"]) <= players and int(game["maxplayers"]) >= players
        ]
    elif players_type == "bggbest":
        collection = [
            game
            for game in collection
            if str(players) in game["bggbestplayers"].split(",")
        ]
    elif players_type == "bggrec":
        collection = [
            game
            for game in collection
            if str(players) in game["bggrecplayers"].split(",")
        ]
    if youngest is not None:
        collection = [
            game
            for game in collection
            if agerangetominage(game["bggrecagerange"]) <= youngest
        ]
    if max_playtime is not None:
        collection = [
            game for game in collection if int(game["maxplaytime"]) <= max_playtime
        ]

    if len(collection) > 0:
        if all:
            collection.sort(key=lambda x: float(x["baverage"]), reverse=True)
            return collection
        else:
            return [collection[int(rand(1, len(collection) - 1)[0])]]
    else:
        return None


def main():
    args = cli()
    collection = csv.DictReader(open(args.collection))

    choice = choose(
        collection,
        players=args.players,
        youngest=args.age_youngest,
        max_playtime=args.playtime_max,
        all=args.all,
        players_type=args.players_type,
    )

    if choice is not None:
        print("You should play:")
        for game in choice:
            print(gameToString(game))
    else:
        print("No game was found that meets these requirements.")


if __name__ == "__main__":
    main()