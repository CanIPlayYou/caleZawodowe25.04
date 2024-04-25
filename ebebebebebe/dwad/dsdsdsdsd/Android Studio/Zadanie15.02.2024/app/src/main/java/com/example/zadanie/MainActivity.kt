package com.example.zadanie

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.SeekBar
import android.widget.Switch
import android.widget.TextView
import kotlin.math.absoluteValue
import kotlin.random.Random

class MainActivity : AppCompatActivity() {

    val lista:MutableList<String> = mutableListOf()

    lateinit var adapter:ArrayAdapter<String>;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btn:Button = findViewById(R.id.button);
        val listView:ListView = findViewById(R.id.list_item)
        val skBar:SeekBar = findViewById(R.id.seekBar)
        val ilLiczbText:TextView = findViewById(R.id.iloscLiczbText);
        val switch:Switch = findViewById(R.id.switch1)

        adapter = ArrayAdapter(this, R.layout.activity_list_item, R.id.row, lista)
        listView.adapter = adapter

        var iloscLiczb:Int = 0;

        skBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener{
            override fun onProgressChanged(seekBar: SeekBar, progress: Int, fromUser: Boolean) {
                iloscLiczb = progress
                ilLiczbText.setText("Ilość liczb: "+ iloscLiczb.toString())
            }

            override fun onStartTrackingTouch(seekBar: SeekBar) {
            }

            override fun onStopTrackingTouch(seekBar: SeekBar) {
            }
        })

        btn.setOnClickListener {
            val liczby:IntArray = IntArray(iloscLiczb);
            for (i in liczby.indices){
                val liczba = Random.nextInt(1, 41)
                liczby[i] = liczba

                adapter.add(liczby[i].toString())
            }
        }

        switch.setOnCheckedChangeListener { buttonView, isChecked ->
            if(isChecked){
                btn.setOnClickListener {
                    val liczby:IntArray = IntArray(iloscLiczb);
                    for (i in liczby.indices){
                        val liczba = Random.nextInt(1, 41)

                        if(!liczby.contains(liczba)) {
                            liczby[i] = liczba

                            adapter.add(liczby[i].toString())
                        }
                    }
                }
            }
            else{
                btn.setOnClickListener {
                    val liczby:IntArray = IntArray(iloscLiczb);
                    for (i in liczby.indices){
                        val liczba = Random.nextInt(1, 41)
                        liczby[i] = liczba

                        adapter.add(liczby[i].toString())
                    }
                }
            }
        }
    }
}