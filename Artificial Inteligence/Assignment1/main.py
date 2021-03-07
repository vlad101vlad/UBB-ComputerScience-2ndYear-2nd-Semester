from random import randint

from Domain.Environment import Environment
from Domain.Map import DMap
from Domain.Drone import Drone
from Domain.constants import *

import sys
import pygame
import time
import easygui


def main():
    # we create the environment
    environment = Environment()
    environment.loadEnvironment("test2.map")
    # print(str(e))

    # we create the map
    droneMap = DMap()

    # initialize the pygame module
    pygame.init()
    # load and set the logo
    logo = pygame.image.load("logo32x32.png")
    pygame.display.set_icon(logo)
    pygame.display.set_caption("drone exploration")

    # Fixed bug, sometimes the drone is spawn in a location which there was a brick
    environmentSurface = environment.getSurface()
    # we position the drone somewhere in the area
    x = randint(0, 19)
    y = randint(0, 19)
    while environmentSurface[x][y] == BRICK:
        # When the random position of the drone is a brick, we generate another random position
        x = randint(0, 19)
        y = randint(0, 19)

    # cream drona
    drone = Drone(x, y)

    # create a surface on screen that has the size of 800 x 480
    screen = pygame.display.set_mode((800, 400))
    screen.fill(WHITE)
    screen.blit(environment.image(), (0, 0))

    # define a variable to control the main loop
    running = True

    # main loop
    while running:
        # droneMap.markDetectedWalls(environment, drone.x, drone.y)
        # screen.blit(droneMap.image(drone.x, drone.y), (400, 0))
        # pygame.display.flip()
        # drone.updateMap(screen, environment, droneMap)
        # event handling, gets all event from the event queue
        # for event in pygame.event.get():
        #
        #     # only do something if the event is of type QUIT
        #     if event.type == pygame.QUIT:
        #         # change the value to False, to exit the main loop
        #         pygame.quit()
        #         raise SystemExit

        # if event.type == pygame.KEYDOWN:
        #     # use this function instead of move
        #     # d.moveDSF(m)
        #     drone.move(map)
        time.sleep(FAST)
        drone.updateMap(screen, environment, droneMap)
        drone.moveDFSIterative(droneMap)
        # drone.moveDFSRecursive(droneMap, screen, environment)

        if not drone.mainStack:
            # When we reach this point, in theory,
            # all the possible discovered blocks were parsed, thus we can exit the game
            drone.x = None
            drone.y = None
            # We set the drone coordinates to 'None as required'

            easygui.msgbox("The map is fully discovered!\n"
                           "The game will automatically close in 3sec after you press ok", title="Game is over")
            time.sleep(3)  # We will automatically close the app after 10 seconds
            break

    pygame.quit()


if __name__ == '__main__':
    main()
