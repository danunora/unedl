package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_RED;

public class MyRunnable implements Runnable {
    @Override
    public void run() {
        System.out.println(ANSI_RED + "RUNNABLE THREAD");
    }
}
