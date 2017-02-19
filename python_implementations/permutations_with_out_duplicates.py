def perms_with_out_dups(astr):
    if len(astr) == 1:
        return [astr]
    first = astr[0]
    rest = astr[1:]
    perms_of_rest = perms_with_out_dups(rest)
    comb_perms = []
    for perm in perms_of_rest:
        for i in xrange(len(perm) + 1):
            comb_perms.append(perm[:i] + first + perm[i:])

    return comb_perms


print perms_with_out_dups('ABCD')
