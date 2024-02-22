package franchise

type Franchise struct {
    numbers map[string]float64
}

func NewFranchise() *Franchise {
    numbers := map[string]float64{
        "one": 4,
        "two": 5,
        "three": 6,
        "four": 1,
        "five": 2,
        "six": 3,
        "seven": 4.5,
        "eight": 7,
        "nine": 8,
        "ten": 9,
    }
    return &Franchise{numbers: numbers}
}

func (f *Franchise) StringToDouble(number string) float64 {
    return f.numbers[number]
}