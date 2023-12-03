class Field:
    def __init__(self, value: str, adjascents):
        self.value = value


def load_plan(input_file: str) -> list[list[Field]]:
    plan = list(list())
    with open(input_file, "r") as file:
        for l in file.readlines():
            row = list()
            plan.append(row)
            for c in l:
                #if c != '\n':
                row.append(Field(c))
    print_plan(plan)


def print_plan(plan: list[list[Field]]):
    for l in plan:
        for c in l:
            print(c.value, end="")

if __name__ == '__main__':
    load_plan("test_input.txt")
