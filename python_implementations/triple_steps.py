def triple_step_valid(num, res=[]):
    if num < 1:
        return 0
    by1 = triple_step_valid(num - 1)
    by2 = triple_step_valid(num - 2)
    by3 = triple_step_valid(num - 3)
    return 1 + by1 + by2 + by3


def triple_step_incorrect(num, res=[]):
    if num < 0:
        return 0
    if num == 0:
        return 1
    by1 = triple_step_incorrect(num - 1)
    by2 = triple_step_incorrect(num - 2)
    by3 = triple_step_incorrect(num - 3)
    return by1 + by2 + by3
