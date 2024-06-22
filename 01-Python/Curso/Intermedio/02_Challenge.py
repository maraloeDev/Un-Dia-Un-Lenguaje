# Challenges

""""
Escribe un programa que muestre por consola (con un print) los
números de 1 a 100
(ambos incluidos y con un salto de línea entre * cada impresión), sustituyendo los siguientes:
- Múltiplos de 3 por la palabra "fizz".
- Múltiplos de 5 por la palabra "buzz".
- Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
"""


def fizzbuzz():
    for mis_numeros in range(1, 101):  # es 1 y 101, por que excluye el primero y el ultimo

        if mis_numeros % 3 == 0 and mis_numeros % 5 == 0:
            print("fizzbuzz")

        elif mis_numeros % 3 == 0:
            print("fizz")

        elif mis_numeros % 5 == 0:
            print("buzz")

        else:

            print(f"{mis_numeros}")


print("FIZZBUZZ")

fizzbuzz()

""""
Escribe una función que reciba dos palabras (String) y retorne
verdadero o falso (Bool) según sean o no anagramas.
    - Un Anagrama consiste en formar una palabra reordenando TODAS
     las letras de otra palabra inicial.
    - NO hace falta comprobar que ambas palabras existan.
    - Dos palabras exactamente iguales no son anagrama.
"""""


def is_anagram(palabra_uno: str, palabra_dos: str):
    if palabra_uno == palabra_dos:
        return False

    # sorted es para ordenar las letras de la palabra
    return sorted(palabra_uno.lower()) == sorted(palabra_dos.lower())


print("IS ANAGRAM")

print(is_anagram("Amor", "Roma"))

"""""
Escribe un programa que imprima los 50 primeros números de la sucesión
de Fibonacci empezando en 0.
- La serie Fibonacci se compone por una sucesión de números en
  la que el siguiente siempre es la suma de los dos anteriores.
  0, 1, 1, 2, 3, 5, 8, 13...

"""""


def sucesion_fibonacci():
    prev = 0
    next = 1

    for fibo in range(0, 50):
        print(prev)
        fib = prev + next
        prev = next
        next = fib


print("SUCESION DE FIBONACCI")

sucesion_fibonacci()

"""
Escribe un programa que se encargue de comprobar si un número es o no primo.
 Hecho esto, imprime los números primos entre 1 y 100.
"""


def numero_primo():
    for numero in range(1, 101):

        if numero >= 2:

            is_divisible = False

            for index in range(2, numero):
                if numero % index == 0:
                    is_divisible = True

            if not is_divisible:
                print(numero)


print("NUMERO PRIMO")
numero_primo()

"""
Crea un programa que invierta el orden de una cadena de texto
sin usar funciones propias del lenguaje que lo hagan de forma automática.
    - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
"""

def dar_vuelta(texto):

    text_length = len(texto)
    reversed_text=""

    for index in range(0, text_length):
        reversed_text += texto[text_length - index - 1]
    return reversed_text

print(dar_vuelta("Hola Mundo"))

