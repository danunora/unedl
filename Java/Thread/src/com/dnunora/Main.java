package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_GREEN;
import static com.dnunora.ThreadColor.ANSI_PURPLE;
import static com.dnunora.ThreadColor.ANSI_RED;

public class Main {

    public static void main(String[] args) {

        System.out.println(ANSI_PURPLE + "Hello from the MAIN thread");

        Thread anotherThread = new AnotherThread();
        anotherThread.setName("ANOTHER THREAD");
//        anotherThread.start();
        anotherThread.run();


        // Anonymous class
        new Thread(){
            public void run() {
                System.out.println(ANSI_GREEN + "Hello from ANONYMOUS class thread");
            }
        }.start();

        System.out.println(ANSI_RED + "Hello AGAIN from the MAIN thread");

    }
}
