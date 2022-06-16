package com.example.tcpreader;

import androidx.activity.result.ActivityResultLauncher;
import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.NumberPicker;
import android.widget.TextView;
import android.widget.Toast;

import com.journeyapps.barcodescanner.ScanContract;
import com.journeyapps.barcodescanner.ScanOptions;

public class MainActivity extends AppCompatActivity {
    TextView np;
    Button bt;
    TextView tv;
    String currentStation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        np = (TextView) findViewById(R.id.eNum);
        tv = (TextView) findViewById(R.id.StationTxt);
        tv.setText("Station ID");
        np.setText("");
        bt = (Button) findViewById(R.id.button);
        bt.setOnClickListener(v ->
        {
            currentStation = np.getText().toString();
            scanCode();
        });
    }

    public void send(String code, String sn){
        MessageSender messageSender = new MessageSender();
        messageSender.execute( sn + "!" + code);
    }

    private void scanCode() {
        ScanOptions options = new ScanOptions();
        options.setPrompt("Volume up to Flash On");
        options.setBeepEnabled(true);
        options.setOrientationLocked(true);
        options.setCaptureActivity(CaptureAct.class);
        barLauncher.launch(options);
    }

    ActivityResultLauncher<ScanOptions> barLauncher = registerForActivityResult(new ScanContract(), result -> {
        AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);
        builder.setTitle("Order Number");
        builder.setMessage(result.getContents());
        builder.setPositiveButton("Send", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
                send(result.getContents(), currentStation);
            }
        }).show();
    });

}