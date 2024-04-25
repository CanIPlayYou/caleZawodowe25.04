package com.example.sprawdzian23_11

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.TextView
import kotlin.random.Random
import kotlin.random.nextInt

class MainActivity : AppCompatActivity() {
    val lista:MutableList<String> = mutableListOf()

    lateinit var adapter:ArrayAdapter<String>;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btn:Button = findViewById(R.id.button1);
        val listView:ListView = findViewById(R.id.list_item);

        adapter = ArrayAdapter(this, R.layout.activity_list_item, R.id.row, lista)
        listView.adapter = adapter

        val liczby = IntArray(10)

        btn.setOnClickListener {
            for (i in liczby.indices){
                val liczba = Random.nextInt(1, 31)

                if(!liczby.contains(liczba)) {
                    liczby[i] = liczba

                    adapter.add(liczby[i].toString())
                }
            }
        }
    }
}