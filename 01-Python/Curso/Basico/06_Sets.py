#Sets no es una estructura orddenada, ni admite repetidos

my_set = set()

print(type(my_set))

my_other_set = {"Carlos", "Pepe", 24}
print(type(my_other_set))

print(my_other_set)
print(len(my_other_set))

my_other_set.add("MaraloeDev")
print(my_other_set)

#in sirve para buscar el elemento
print("Edu" in my_other_set)
print("Carlos" in my_other_set)

print(my_other_set)
my_other_set.remove("Carlos")
print(my_other_set)

my_copy_set = my_other_set.copy()

my_other_set.clear()
print(len(my_other_set))

print(my_copy_set)

my_set  = {"Carlos", "Pepe", 24, "C", "HTML"}
my_list = list(my_set)

print(my_list[0])

my_new_set = my_set.union(my_copy_set)
print(my_new_set)

print(len(my_new_set))

