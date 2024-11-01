window.registerBlazorCounter = () => {
    console.log("Register Blazor Counter gestart");
    customElements.define('blazor-counter', class extends HTMLElement {
        constructor() {
            super();
            this.attachShadow({ mode: 'open' });
        }

        connectedCallback() {
            console.log("Blazor Counter connectedCallback aangeroepen");
            Blazor.rootComponents.add('CounterElement', this.shadowRoot);
        }
    });
};
