FROM nginx:alpine

# Verwijder de standaard Nginx-pagina
RUN rm -rf /usr/share/nginx/html/*

# Kopieer de gepubliceerde Blazor-app naar de Nginx HTML-directory
COPY ./publish/wwwroot /usr/share/nginx/html

# Kopieer de aangepaste Nginx-configuratie
COPY nginx.conf /etc/nginx/conf.d/default.conf

# (Optioneel) Kopieer het JavaScript-bestand voor webcomponenten
# COPY ./publish/customElements.js /usr/share/nginx/html/customElements.js

# Expose poort 80
EXPOSE 80

# Start Nginx
CMD ["nginx", "-g", "daemon off;"]
