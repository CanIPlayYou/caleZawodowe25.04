package com.example.sprawdzian

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.SeekBar
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val rozText:TextView = findViewById(R.id.rozmiarText);
        val skBar:SeekBar = findViewById(R.id.seekBar1);
        val cytatText:TextView = findViewById(R.id.underSeekBarText);
        val btn:Button = findViewById(R.id.button1);

        btn.setOnClickListener {
            if(cytatText.text == ""){
                cytatText.setText("Dzień dobry");
            }
            else if(cytatText.text == "Dzień dobry"){
                cytatText.setText("Good morning");
            }
            else if(cytatText.text == "Good morning"){
                cytatText.setText("Buenos dias");
            }
            else if(cytatText.text == "Buenos dias"){
                cytatText.setText("Dzień dobry")
            }

            rozText.setText((skBar.progress).toString())
        }
    }
}
