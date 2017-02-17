def powerSet(aset):
    if not aset:
        return [[]]
    first = aset[0]
    rest = aset[1:]
    subsets_of_rest = powerSet(rest)
    combo_subsets = [[first] + sub for sub in subsets_of_rest]
    return subsets_of_rest + combo_subsets

print powerSet([1, 2, 3, 4])
