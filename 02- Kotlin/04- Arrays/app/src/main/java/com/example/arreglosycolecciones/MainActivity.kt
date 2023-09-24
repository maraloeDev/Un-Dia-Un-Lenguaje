package com.example.arreglosycolecciones

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    // Una array almacena valores de un mismo tipo

    fun arrays(){

        val nombre = "Eduardo"
        val apellido = "Martin-Sonseca"
        val anios = 23

        // Creación de un Array (Admite elementos repetidos)

        val datos = arrayListOf<String>(nombre, apellido, anios.toString())

        datos.add(nombre)
        datos.add(apellido)
        datos.add(anios.toString())
        datos.add(anios.toString())
        println(datos)

        //Añadir un conjunto de elementos a un array

        datos.addAll(listOf("Hola", "Adios"))

        println(datos)

        // Acceso a datos
        val nombreHumano = datos[0]

        // Modificación de datos

        datos[0] = "Edu"
        println(datos)

        // Eliminación de datos

        datos.removeAt(0) // Elimino el elemento en la posición 0

        println(datos)

        // Recorrer un array

        for (dato in datos) {
            println(dato)
        }

    }
}