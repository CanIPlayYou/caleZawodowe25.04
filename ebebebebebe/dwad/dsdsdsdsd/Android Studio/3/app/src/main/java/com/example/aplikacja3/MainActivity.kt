package com.example.aplikacja3

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.ListView
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    val lista:MutableList<String> = mutableListOf(
        "Zakupy: chleb, masło, ser",
        "Do zrobienia: obiad, umyć podłogi",
        "weekend: kino, spacer z psem")

    lateinit var adapter:ArrayAdapter<String>;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val listView:ListView = findViewById(R.id.list_item);
        val btn:Button = findViewById(R.id.button1);
        val editText:EditText = findViewById(R.id.editText);

        adapter = ArrayAdapter(this, R.layout.activity_list_item, R.id.row, lista)  //Lista z możliwościa edycji stylu - activity_list_item (trzeba dorobic plik layoutu). row to id danego elementu, id definiuje sie w pliku layoutu
        listView.adapter = adapter


        //Prosta lista bez możliwości edycji stylu - simple_list_item_1
        /* var adapter:ArrayAdapter<String>;
        adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, mutableListOf("Zakupy: chleb, masło, ser", "Do zrobienia: obiad, umyć podłogi", "weekend: kino, spacer z psem"))
        listView.adapter = adapter */

        btn.setOnClickListener {
            adapter.add(editText.text.toString());
        }
        
        /*listView.onItemClickListener = AdapterView.OnItemClickListener { parent, view, position, id ->
            removeItem(position)
        }*/ //Usuwa po kliknieciu na item listy



        listView.setOnItemClickListener { parent, view, position, id ->
            val delIcon:ImageView = view.findViewById(R.id.delIcon)
            delIcon.setOnClickListener{
                removeItem(position)
            }
        }
    }

    fun removeItem(position: Int){
        lista.removeAt(position)
        adapter.notifyDataSetChanged()
        Toast.makeText(this,"Usunięto element z pozycji $position", Toast.LENGTH_LONG).show()
    }
}