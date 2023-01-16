# Dockerfile experiment for CVRHOC. This will use Alpine to install the prototype, install Nginx, configure the server and start it.

FROM alpine:latest

#Install packages using apk
RUN apk update && apk add \
    nginx \
    git

#Get the repo from da web
RUN git clone https://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@github.com/DomWilson2/CVRHOCDeployment.git
RUN cd CVRHOCDeployment && git init && git fetch && git pull

#Nginx initialization
RUN cp /CVRHOCDeployment/nginx.conf /etc/nginx/nginx.conf
RUN chmod 755 /CVRHOCDeployment/init.sh
CMD ["/CVRHOCDeployment/init.sh"]

EXPOSE 32401
