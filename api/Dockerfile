FROM python:3.7.4
ENV PYTHONUNBUFFERED 1

WORKDIR /api

RUN pip install Flask
RUN pip install requests
COPY . .
EXPOSE 5000
# CMD [ "flask", "--app", "hello", "run", "--debug", '--host=0.0.0.0']