package com.example.mapas_dicionario

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    fun mapas() {


        var myMap : Map<String, Int>  = mapOf();

        // Añadir valores
        myMap = mutableMapOf("Eduardo" to 1, "Carmen" to 2);
        println(myMap)

        // Acceder a los valores
        println(myMap["Eduardo"])

        // Actualizacion

        myMap.put("Eduardo", 50)

        // Borrado de datos
        myMap.remove("Eduardo")

        println(myMap)
    }
}