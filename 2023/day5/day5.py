def parse_soil_to_fertilizer(lines: str) -> dict[int, int]:
    pass


def parse_fertilizer_to_water(lines: str) -> dict[int, int]:
    pass


def parse_water_to_light(lines: str) -> dict[int, int]:
    pass


def parse_light_to_temp(lines: str) -> dict[int, int]:
    pass


def parse_temp_to_humidity(lines: str) -> dict[int, int]:
    pass


def parse_humidity_to_location(lines: str) -> dict[int, int]:
    pass


def parse(input_file: str):
    with open(input_file, "r") as file:
        parts = file.read().split("\n\n")
    seeds = map(int, parts[0].split(":")[1].strip().split(" "))
    seed_to_soil = parse_seed_to_soil(parts[1])
    soil_to_fertilizer = parse_soil_to_fertilizer(parts[2])
    fertilizer_to_water = parse_fertilizer_to_water(parts[3])
    water_to_light = parse_water_to_light(parts[4])
    light_to_temp = parse_light_to_temp(parts[5])
    temp_to_humidity = parse_temp_to_humidity(parts[6])
    humidity_to_location = parse_humidity_to_location(parts[7])


def parse_seed_to_soil(lines: str) -> dict[int, int]:
    for line in lines.split("\n"):
        dest, src, rng = line.strip().split(" ")
        for i in range(rng):
