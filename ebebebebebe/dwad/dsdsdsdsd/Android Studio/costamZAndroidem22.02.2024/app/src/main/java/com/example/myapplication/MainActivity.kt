package com.example.myapplication

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.SeekBar
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val seekBar:SeekBar = findViewById(R.id.seekBar)
        val textView1:TextView = findViewById(R.id.textView1)
        val textView2:TextView = findViewById(R.id.textView2)

        var liczba:Int = 0;


        seekBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener{
            override fun onStartTrackingTouch(seekBar: SeekBar?) {
                textView1.setBackgroundColor(Color.MAGENTA)
                textView1.setTextColor(Color.WHITE)
            }

            override fun onProgressChanged(seekBar: SeekBar?, progress: Int, fromUser: Boolean) {
                liczba = progress
                textView1.text = liczba.toString()
            }

            override fun onStopTrackingTouch(seekBar: SeekBar?) {
                textView2.text = liczba.toString()
                textView1.setBackgroundColor(Color.WHITE)
                textView1.setTextColor(Color.RED)
            }
        })
    }
}