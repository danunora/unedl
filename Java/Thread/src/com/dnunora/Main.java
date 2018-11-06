package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_GREEN;
import static com.dnunora.ThreadColor.ANSI_PURPLE;
import static com.dnunora.ThreadColor.ANSI_RED;

public class Main {

    public static void main(String[] args) {

        System.out.println(ANSI_PURPLE + "Hello from the MAIN thread");

        Thread anotherThread = new AnotherThread();
        anotherThread.setName("ANOTHER THREAD");

        // anotherThread.start() should be used to execute the new thread
        // if run() is usead instead, it will be referring to local thread.
        anotherThread.start();

        // Anonymous class, should be used if only this code will be executed
        // in other case, a class should be created.
        new Thread(){
            public void run() {
                System.out.println(ANSI_GREEN + "Hello from ANONYMOUS class thread");
            }
        }.start();

        System.out.println(ANSI_RED + "Hello AGAIN from the MAIN thread");

    }
}
