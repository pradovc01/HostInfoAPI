# Docker Description
This is a quick description of Hostname information project with Docker technology

## _Docker Container_

Commands to create an image, run the container and upload the image to the cloud:
1. docker build -t \<dockerID\>/\<imagename\> .: Build a docker image <br>

     docker build -t- pradovc01/hostnameinfoapi
2. docker images : list docker images : you will see all images available in your local repository
3. docker run -p <localPort>:<port> <dockerID>/<imagename> : You can run the image

    docker run -p 8080:80 pradovc01/hostnameinfoapi:veronica.prado
4. docker push \<dockerId\>/\<imagename\>:\<tag\> :  You can upload the image to repository (private/public)