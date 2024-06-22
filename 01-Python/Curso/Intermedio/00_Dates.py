# Dates  #Una fecha es una representación de un dio, un mes, un año...

from datetime import datetime

mi_fecha = datetime.now()


def print_date(dia):
    print(dia.year)
    print(dia.month)
    print(dia.hour)
    print(dia.minute)
    print(dia.second)
    print(dia.timestamp())


print(mi_fecha)

year2024 = datetime(2024, 6, 19)

print(print_date(mi_fecha))

from datetime import time

current_time = time(21, 3, 22)

print(current_time.hour)
print(current_time.minute)
print(current_time.second)

from datetime import date

current_date = date.today()

print(current_date)
print(current_date.day)
print(current_date.month)
print(current_date.year)

current_date = date(2024,5,19)

print(current_date)

current_date = date(current_date.year, current_date.month, current_date.day)

print(current_date.month)


diff = year2024 - mi_fecha
print(diff)

diff = year2024.date() - current_date

print(diff)

from datetime import timedelta #El TimeDelta, sirve para operar con diferentes fechas

start_timedelta = timedelta(200,10000,12000,9,23,12,weeks=2024)
end_timedelta = timedelta(100,22000,44000,9,23,12,weeks=2012)

print(f"SUMA {start_timedelta} + {end_timedelta}")
print(f"RESTA {start_timedelta} - {end_timedelta}")