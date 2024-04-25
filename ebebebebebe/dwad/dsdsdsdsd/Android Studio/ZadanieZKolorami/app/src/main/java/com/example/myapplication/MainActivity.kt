package com.example.myapplication

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.Layout
import android.util.TypedValue
import android.view.View
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.SeekBar
import android.widget.TextView
import androidx.constraintlayout.widget.ConstraintSet
import org.w3c.dom.Text

class MainActivity : AppCompatActivity() {
    val lista:MutableList<String> = mutableListOf()

    lateinit var adapter: ArrayAdapter<String>;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btn:Button = findViewById(R.id.button1);
        val btn2:Button = findViewById(R.id.button2);

        val cSeekBarR:SeekBar = findViewById(R.id.seekBarR);
        val cSeekBarG:SeekBar = findViewById(R.id.seekBarG);
        val cSeekBarB:SeekBar = findViewById(R.id.seekBarB);
        val colorTextView:TextView = findViewById(R.id.textViewColor);

        val listView:ListView = findViewById(R.id.list_item);
        adapter = ArrayAdapter(this, R.layout.activity_list_item, R.id.row, lista)
        listView.adapter = adapter

        val inflatedView: View = layoutInflater.inflate(R.layout.activity_list_item, null, false)

        val listColorTextView:TextView = inflatedView.findViewById(R.id.row)
        val btnList:Button = inflatedView.findViewById(R.id.buttonInList)

        btn.setOnClickListener(){
            val color = Color.rgb(cSeekBarR.progress, cSeekBarG.progress, cSeekBarB.progress)

            colorTextView.text = "Kolor: #${Integer.toHexString(color).substring(2)}"
            colorTextView.setTextColor(color)
            colorTextView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 20F)
        }

        btn2.setOnClickListener(){
            val color = Color.rgb(cSeekBarR.progress, cSeekBarG.progress, cSeekBarB.progress)

            adapter.add(colorTextView.text.toString())
            listColorTextView.setTextColor(color)
            btnList.setBackgroundColor(color)
        }
    }
}
