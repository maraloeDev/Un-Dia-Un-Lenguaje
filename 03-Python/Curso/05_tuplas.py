# Tuplas es un conjunto de valores en los que no se pueden modificar

my_tuple = tuple()
my_other_tuple = ()

my_tuple = (8, "Eduardo", 23, "Martin-Sonseca")
my_other_tuple = (84, 23, 12, 90, 43)

print(my_tuple)
print(my_tuple[1])

print(my_tuple.count(23))
print(my_tuple.index(8))

my_sum_tuples = my_tuple + my_other_tuple
print(my_sum_tuples)
print(my_sum_tuples[0:3])

my_tuple = list(my_tuple)

my_tuple.insert(0, 24)
print(my_tuple)

my_tuple = tuple(my_tuple)
print(type(my_tuple))
