def perms_with_dups(astr):
    if len(astr) == 1:
        return (astr,)
    first = astr[0]
    rest = astr[1:]
    perms_of_rest = perms_with_dups(rest)
    comb_perms = set()
    for perm in perms_of_rest:
        for i in xrange(len(perm) + 1):
            # print perm[:i]
            # print first
            # print perm[i:]
            comb_perms.add(perm[:i] + first + perm[i:])

    return comb_perms


print perms_with_dups('AABB')
