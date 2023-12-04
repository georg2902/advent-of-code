class Card:
    def __init__(self, winning: list[int], numbers: list[int]):
        self.winning = winning
        self.numbers = numbers

    @staticmethod
    def parse_card(line: str) -> 'Card':
        relevant = line.split(":")[1]
        winning, numbers = relevant.strip().split("|")
        winning_as_int = [int(w) for w in winning.strip().split(" ") if len(w) > 0]
        numbers_as_int = [int(n) for n in numbers.strip().split(" ") if len(n) > 0]
        return Card(winning_as_int, numbers_as_int)

    def validate(self) -> int:
        multiplier = 0
        for n in self.numbers:
            if n in self.winning:
                multiplier += 1
        return 2 ** (multiplier - 1) if multiplier > 0 else 0


def parse_cards(input_file: str):
    with open(input_file, "r") as file:
        cards = [Card.parse_card(l) for l in file.readlines()]
        cards_sum = sum([c.validate() for c in cards])
    return cards_sum


if __name__ == '__main__':
    print(parse_cards("test_input.txt"))
    print(parse_cards("input.txt"))