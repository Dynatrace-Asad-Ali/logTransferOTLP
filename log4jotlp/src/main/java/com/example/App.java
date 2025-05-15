package com.example;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

/**
 * Hello world!
 *
 */
public class App {
    protected static final Logger logger = LogManager.getLogger();

    public static void main(String[] args) {

        for (int i=0; ; i++) {
            logger.info("Hello World! " + i);
            try {
                Thread.sleep(10000);
            }
            catch (Exception e) {}
        }

    }
}
