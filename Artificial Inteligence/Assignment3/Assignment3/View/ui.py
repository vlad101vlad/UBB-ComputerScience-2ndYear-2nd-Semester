# -*- coding: utf-8 -*-
# imports
# create a menu
#   1. map options:
#         a. create random map
#         b. load a map
#         c. save a map
#         d visualise map
#   2. EA options:
#         a. parameters setup
#         b. run the solver
#         c. visualise the statistics
#         d. view the drone moving on a path
#              function gui.movingDrone(currentMap, path, speed, markseen)
#              ATENTION! the function doesn't check if the path passes trough walls


def printMenu():
    print("1. Menu options\n"
          "2. EA options\n"
          "x - Exit\n\n")


def printMapOptions():
    print("a. Create a random map\n"
          "b. Load a map\n"
          "c. Save a map\n"
          "d. Visualise a map\n"
          "x - Back\n\n")


def printEAOptions():
    print("a. Parameters setup\n"
          "b. Run the solver\n"
          "c. Visualise the statistics\n"
          "d. View the drone moving on a path\n"
          "x - Back\n\n")
